using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using ThanhDLL;
using System.Windows.Forms;

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




        public List<Article> GetLoanArticles(int shopnr)
        {
            String sql = "SELECT * FROM loan_article WHERE ShopNr=" + Convert.ToString(shopnr);
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Article> temp;
            temp = new List<Article>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                double price;
                string img = "";
                int stock;
                //string shopname;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["ArticleName"]);
                    //shopname = Convert.ToString(reader["ShopName"]);
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    shopnr = Convert.ToInt32(reader["ShopNr"]);
                    price = Convert.ToInt32(reader["price"]);
                    if (!(reader["Img"] is DBNull))
                    {
                        img = Convert.ToString(reader["Img"]);
                    }
                    stock = Convert.ToInt32(reader["Available"]);
                    temp.Add(new Article(shopnr, nr, name, price, stock));
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

    }
}
