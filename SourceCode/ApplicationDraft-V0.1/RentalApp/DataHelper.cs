using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using ThanhDLL;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace RentalApp
{
    public class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +//the hera-server
                                    "database=dbi387862;" +
                                    "user id=dbi387862;" +
                                    "password=blueberrypie;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }




        public List<LoanArticle> GetLoanArticle(RFIDTag o)
        {
            String sql = "SELECT * FROM loan_article WHERE RFIDNr=" + o;
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<LoanArticle> temp;
            temp = new List<LoanArticle>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int shopnr;
                int nr;
                double price;
                string img = "";
                int stock;
                //string shopname;
                string rfidNo;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    shopnr = Convert.ToInt32(reader["ShopNr"]);
                    price = Convert.ToInt32(reader["LoanFee"]);
                    if (!(reader["Img"] is DBNull))
                    {
                        img = Convert.ToString(reader["Img"]);
                    }
                    rfidNo = Convert.ToString(reader["RFIDNr"]);
                    stock = Convert.ToInt32(reader["IsReturned"]);
                    temp.Add(new LoanArticle(shopnr, nr, name, price, stock, rfidNo));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }



        public int CreateNewOrder(Order o)
        {
            string sql = "INSERT INTO SHOP_ORDER(OrderDate, OrderTime, ShopNr, VisitorNr) " +
                       "VALUES(CONVERT('" + o.OrderDate + "', DATE), CONVERT('" + o.OrderTime + "', TIME), " + o.Shop.ShopNr + ", " + o.VisitorNr + ")";
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get the latest order number
        /// </summary>
        /// <returns>The biggest order number in database</returns>
        public int GetLatestOrderNr()
        {
            string sql = "SELECT MAX(OrderNr) FROM SHOP_ORDER";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Add order lines for a given order 
        /// </summary>
        /// <param name="o">The given order</param>
        /// <returns>Number of rows affected</returns>
        public int AddOrderLine(Order o)
        {
            string sql = "";

            for (int i = 0; i < o.Articles.Count; i++)
            {
                sql += "INSERT INTO SHOP_ORDER_LINE(OrderNr, LineNr, ArticleNr, Quantity) " +
                       "VALUES(" + GetLatestOrderNr() + ", " + (i + 1) + ", " + o.Articles[i].ArticleNr + ", "
                       + o.Quantity[i] + ");";

                sql += " UPDATE ARTICLE SET Available = Available - " + o.Quantity[i] + " WHERE ArticleNr = " +
                    o.Articles[i].ArticleNr + " AND ShopNr = " + o.Shop.ShopNr + ";";
            }

            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// Reading data onto a visitor
        /// </summary>
        /// <param name="reader">MySQL's reader</param>
        /// <param name="v">The selected visitor</param>
        /// <returns>The selected visitor initialized</returns>
        public Visitor ReadDataVisitor(MySqlDataReader reader, Visitor v)
        {

            // reading
            while (reader.Read())
            {
                // temporary variables
                int nr;
                string first;
                string last;
                string phone;
                string mail;
                string rfidNr = "";
                double cred = 0;
                bool checkedIn;
                int spot = 0; // not reserved by default

                nr = Convert.ToInt32(reader["VisitorNr"]);
                first = Convert.ToString(reader["FirstName"]);
                last = Convert.ToString(reader["LastName"]);
                phone = Convert.ToString(reader["Phone"]);
                mail = Convert.ToString(reader["Email"]);
                if (!(reader["RFIDNr"] is DBNull))
                {
                    rfidNr = Convert.ToString(reader["RFIDNr"]);
                }
                else
                {
                    rfidNr = "";
                }

                if (!(reader["Credit"] is DBNull))
                {
                    cred = Convert.ToDouble(reader["Credit"]);
                }
                checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                if (!(reader["SpotNr"] is DBNull))
                {
                    spot = Convert.ToInt32(reader["SpotNr"]);
                }

                v = (new Visitor(nr, first, last, phone, mail, rfidNr, checkedIn, cred, spot));
            }
            return v;
        }

        /// <summary>
        /// Finds visitor by RFID tag
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public Visitor FindVisitorByTag(string rfidNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE RFIDNr = '" + rfidNr + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException exc)
            {
                //ggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        ///////////////////////////////////////
        // VISITOR'S HANDLING
        ///////////////////////////////////////

        /// <summary>
        ///  Updates credit, checked in status and rfid of the selected visitor in the database 
        /// </summary>
        /// <param name="v">The selected visitor</param>
        /// <returns>-1 if fails, otherwise returns nr. of record affected (should be 1)</returns>
        public int UpdateSelectedVisitor(Visitor v)
        {
            string sql = "UPDATE VISITOR " +
                        "SET Credit = " + v.Credit + "," +
                        "CheckedIn = " + v.CheckedIn + "," +
                        "RFIDNr = " + (v.RFIDNr == "" ? "NULL" : "'" + v.RFIDNr + "'");

            if (v.SpotNr != 0) // if they reserve a spot
            {
                sql += ", SpotNr = " + v.SpotNr;
            }

            sql += " WHERE VisitorNr = " + v.IdNr;

            //MessageBox.Show(sql);

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch (MySqlException exc)
            {

                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
