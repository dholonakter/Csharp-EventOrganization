using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using necessary references
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace ProPApp
{
    class DataHelper
    {
        // connection obj
        MySqlConnection connection;

        // constructor
        public DataHelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi387862;" +
                                    "user id=dbi387862;" +
                                    "password=blueberrypie;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }

        // methods

        #region VISITOR_HANDLING 
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
                        "Paid = " + v.Paid + "," +
                        "RFIDNr = " + (v.RFIDNr == "" ? "NULL" : v.RFIDNr) + " " +
                        "WHERE VisitorNr = " + v.VisitorNr;

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
                MessageBox.Show(exc.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public Visitor ReadDataVisitor(MySqlDataReader reader, Visitor v)
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
            bool paid;
            // reading
            while (reader.Read())
            {
                nr = Convert.ToInt32(reader["VisitorNr"]);
                first = Convert.ToString(reader["FirstName"]);
                last = Convert.ToString(reader["LastName"]);
                phone = Convert.ToString(reader["Phone"]);
                mail = Convert.ToString(reader["Email"]);
                if (!(reader["RFIDNr"] is DBNull))
                {
                    rfidNr = Convert.ToString(reader["RFIDNr"]);
                }
                if (!(reader["Credit"] is DBNull))
                {
                    cred = Convert.ToDouble(reader["Credit"]);
                }
                checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                paid = Convert.ToBoolean(reader["Paid"]);
                v = (new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn, paid));
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
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        /// <summary>
        /// Links a visitor to a RFID card and updates it in the database
        /// </summary>
        /// <param name="v"></param>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public bool LinkRFID(Visitor v, string rfidNr)
        {
            if (existsRFID(rfidNr))
            {
                return false;
            }
            else
            {
                v.RFIDNr = rfidNr;
                v.CheckedIn = true;

                int updated = UpdateSelectedVisitor(v);

                if (updated == 1) // only 1 visior's information should be updated
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        ///  returns all visitors in the database as a list of visitor object
        /// </summary>
        /// <returns>A list of visitor object</returns>
        public List<Visitor> GetAllVisitors()
        {
            string sql = "SELECT * FROM VISITOR";
            List<Visitor> temp = new List<Visitor>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string first;
                string last;
                string phone;
                string mail;
                string rfidNr = "";
                double cred = 0;
                bool checkedIn;
                bool paid;
                // reading
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["VisitorNr"]);
                    first = Convert.ToString(reader["FirstName"]);
                    last = Convert.ToString(reader["LastName"]);
                    phone = Convert.ToString(reader["Phone"]);
                    mail = Convert.ToString(reader["Email"]);
                    if (!(reader["RFIDNr"] is DBNull && reader["RFIDNr"].ToString() == ""))
                    {
                        rfidNr = Convert.ToString(reader["RFIDNr"]);
                    } 
                    if (!(reader["Credit"] is DBNull))
                    {
                        cred = Convert.ToDouble(reader["Credit"]);
                    }
                    checkedIn = Convert.ToBoolean(reader["CheckedIn"]);
                    paid = Convert.ToBoolean(reader["Paid"]);
                    temp.Add(new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn, paid));
                }
                return temp;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
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

        /// <summary>
        /// Finds all unreturned items and adds it to the selected visitor's object list
        /// </summary>
        /// <param name="v"></param>
        public void FindUnreturnedItems(Visitor v)
        {
            string sql = "SELECT StoreNr, ArticleNr, ArticleName FROM NOT_RETURNED WHERE VisitorNr = " + v.VisitorNr;
            
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
                        int storeNr;
                        int articleNr;
                        string articleName;

                        storeNr = Convert.ToInt32(reader["StoreNr"]);
                        articleNr = Convert.ToInt32(reader["ArticleNr"]);
                        articleName = Convert.ToString(reader["ArticleName"]);

                        StoreArticle a = (new StoreArticle(storeNr, articleNr, articleName));
                        v.ArticlesBorrowed.Add(a);
                    }
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region RFID_HANDLING 
        /// <summary>
        /// Gets all the RFID already used
        /// </summary>
        /// <returns></returns>
        public List<String> GetAllRFIDs()
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
                    usedRIFD.Add(Convert.ToString(reader["RFIDNr"]));
                }
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return usedRIFD;
        }

        /// <summary>
        /// Checks if a certain RFID tag exists in the database
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public bool existsRFID(string rfidNr)
        {
            List<String> usedRfids = GetAllRFIDs();
            if (usedRfids.Count > 0)
            {
                foreach (string s in usedRfids)
                {
                    if (s == rfidNr)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Finds visitor by RFID tag
        /// </summary>
        /// <param name="rfidNr"></param>
        /// <returns></returns>
        public Visitor FindVisitorByTag(string rfidNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE RFIDNr = " + rfidNr;
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                v = ReadDataVisitor(reader, v);
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }
        #endregion

        #region STORE_HANDLING
        /// <summary>
        /// Gets all stores in database with their locations
        /// </summary>
        /// <returns></returns>
        public List<Store> GetAllStores()
        {
            string sql = "SELECT * FROM LIST_OF_STORES";
            List<Store> temp = new List<Store>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string name;
                string loc;

                // reading
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["StoreNr"]);
                    name = Convert.ToString(reader["StoreName"]);
                    loc = Convert.ToString(reader["LocationName"]);

                    temp.Add(new Store(nr, name, loc));
                }
                return temp;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
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

        public List<StoreArticle> GetArticlesOfStore(Store s)
        {
            string sql = "SELECT * FROM STORE_ARTICLE WHERE StoreNr = " + s.StoreNr;
            List<StoreArticle> temp = new List<StoreArticle>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // temporary variables
                int nr;
                string name;
                decimal price;
                int stock;
                string img = "";

                // reading
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["ArticleNr"]);
                    name = Convert.ToString(reader["ArticleName"]);
                    price = Convert.ToDecimal(reader["UnitPrice"]);
                    stock = Convert.ToInt32(reader["InStock"]);
                    if (!(reader["img"] is DBNull))
                    {
                        img = Convert.ToString(reader["img"]);
                    }
                    temp.Add(new StoreArticle(s.StoreNr, nr, name, price, stock, img));
                }
                return temp;
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
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
        #endregion
    }
}
