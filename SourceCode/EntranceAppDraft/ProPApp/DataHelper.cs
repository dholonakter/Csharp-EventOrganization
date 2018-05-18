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
        /// <summary>
        ///  This method updates credit, checked in status and rfid of the selected visitor in the database 
        /// </summary>
        /// <param name="v">The selected visitor</param>
        /// <returns>-1 if fails, otherwise returns nr. of record affected (should be 1)</returns>
        public int UpdateSelectedVisitor(Visitor v)
        {
            string sql = "UPDATE VISITOR " +
                        "SET Credit = " + v.Credit + "," +
                        "CheckedIn = " + v.CheckedIn + "," +
                        "RFIDNr = '" + v.RFIDNr + "'" + 
                        "WHERE VisitorNr = " + v.VisitorNr;
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

        /// <summary>
        /// This method finds the visitor with a given visitorNr
        /// </summary>
        /// <param name="visitorNr"></param>
        /// <returns>Returns null if fails and the object visitor initiated if found</returns>
        public Visitor FindVisitor(string visitorNr)
        {
            Visitor v = null;
            string sql = "SELECT * FROM VISITOR WHERE VisitorNr = " + visitorNr;
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
                    v = (new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn));
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
            return v;
        }

        /// <summary>
        /// This method links a visitor to a RFID card and updates it in the database
        /// </summary>
        /// <param name="v"></param>
        /// <param name="rfidNr"></param>
        /// <returns>true if successful and false if not</returns>
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
        /// This method returns all visitors in the database as a list of visitor object
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
                    temp.Add(new Visitor(nr, first, last, phone, mail, rfidNr, cred, checkedIn));
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
            return temp;
        }


        // *** THE CODE BELOW IS TO FIND A CERTAIN RFID. USEFULNESS CAN BE DISCUSSED I JUST WANNA HAVE FUN *** //
        /// <summary>
        /// This method gets all the RFID already used
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
        public bool existsRFID (string rfidNr)
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
    }
}
