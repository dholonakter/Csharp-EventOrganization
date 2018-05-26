using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using ThanhDLL;

namespace EntranceApp
{
    class DataHelper
    {
        ///////////////////////////////////////
        // CONNECTING TO DATABASE
        ///////////////////////////////////////
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;

        /**
         * Constructors
         */
        public DataHelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi387862;" +
                                    "user id=dbi387862;" +
                                    "password=blueberrypie;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            dataAdapter = new MySqlDataAdapter();
        }

        ///////////////////////////////////////
        // DATA TABLES
        ///////////////////////////////////////
        /// <summary>
        /// Loads visitor's information into a data table
        /// </summary>
        /// <returns></returns>
        public DataTable LoadVisitors()
        {
            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM VISITOR", connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Updates datatable
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool UpdateVisitorsTable(DataTable table)
        {
            try
            {
                dataAdapter.Update(table);
            }
            catch (MySqlException)
            {
                //System.Windows.Forms.MessageBox.Show(exc.Message);
                return false;
            }
            return true;
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
        ///  Finds the visitor with a given visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns>Returns null if fails and the object visitor initiated if found</returns>
        public Visitor FindVisitorByNr(string visitorNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE VisitorNr = " + visitorNr;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException exc)
            {
                
            }
            catch (Exception exc)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        /// <summary>
        /// Finds all unreturned items and adds it to the selected visitor's object list
        /// </summary>
        /// <param name="v">Selected visitor</param>
        public void FindUnreturnedItems(Visitor v)
        {
            string sql = "SELECT ShopName, ArticleNr, ArticleName " +
                "FROM ORDER_LOAN " +
                "WHERE VisitorNr = " + v.IdNr + " AND IsReturned = 0";

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return;
                }
                else
                {
                    while (reader.Read())
                    {
                        // temporary variables
                        string shopName;
                        int articleNr;
                        string articleName;

                        shopName = Convert.ToString(reader["ShopName"]);
                        articleNr = Convert.ToInt32(reader["ArticleNr"]);
                        articleName = Convert.ToString(reader["ArticleName"]);

                        LoanArticle a = (new LoanArticle(shopName, articleNr, articleName));
                        v.ArticlesBorrowed.Add(a);
                    }
                }
            }
            catch (MySqlException exc)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Checks if a certain RFID tag exists in the database
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public string existsRFID(string rfidNr)
        {
            string sql = "SELECT RFIDNr FROM VISITOR WHERE RFIDNr IS NOT NULL";
            List<string> usedRIFD = new List<string>();

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (rfidNr == (Convert.ToString(reader["RFIDNr"])))
                    {
                        return rfidNr;
                    }
                }
            }
            catch (MySqlException exc)
            {
                //LoggingError(ErrorTypes.ErrorType.DATABASE, exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        /// <summary>
        /// Returns the ticket with a specified visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns></returns>
        public Ticket GetTicketStatusForVisitor(int visitorNr)
        {
            string sql = "SELECT * " +
                "FROM TICKET " +
                "WHERE BuyerNr = " + visitorNr;

            Ticket t = null;

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string date;
                string time;
                string type;
                bool paid;

                while (reader.Read())
                {
                    // reading
                    nr = Convert.ToInt32(reader["TicketNr"]);
                    date = Convert.ToString(reader["TicketDate"]);
                    time = Convert.ToString(reader["TicketTime"]);
                    type = Convert.ToString(reader["TicketType"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    t = new Ticket(nr, date, time, visitorNr, type, paid);
                }

            }
            catch (MySqlException exc)
            {

            }
            finally
            {
                connection.Close();
            }
            return t;
        }
    }
}
