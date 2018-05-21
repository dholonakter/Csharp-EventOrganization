using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using EntranceApp.Helper;

namespace EntranceApp
{
    public class DatabaseHelper
    {
        #region Private Fields
        private MySqlConnection connection;
        private ILogger logger;
        #endregion

        #region Properties
        public bool Isconnected { get; set; }
        #endregion

        #region Constructor
        public DatabaseHelper(ILogger logger)
        {
            this.logger = logger;
            try
            {
                String connectionInfo = "server=studmysql01.fhict.local;" +//the hera-server
                               "database=dbi364365;" +
                               "user id=dbi364365;" +
                               "password=Dholon;";
                connection = new MySqlConnection(connectionInfo);
                
          
                LoggingError(ErrorType.Database, "Connected");
                
                Isconnected = true;
            }
            catch
            {
                connection.Close();
                LoggingError(ErrorType.Database, "Something went wrong cannot connect");
                
            }
        }
        #endregion

        #region Private Methods
        private void LoggingError(ErrorType errorType, String message)
        {
            if (this.logger != null)
            {
                logger.LogMessage(errorType, message);
            }
        }
        private Visitor FindVisitor(string rfidCode)
        {
            Visitor foundVisitor = null;
            string sql = "SELECT * FROM visitor WHERE RFID ='" + rfidCode+"'";
            
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                int id;
                string fullName;
                int phone;
                string mail;
                bool isCardLinked, isCheckedIn;
                double balance;
                // reading
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    fullName = Convert.ToString(reader["FullName"]);
                    phone = Convert.ToInt32(reader["PhoneNumber"]);
                    mail = Convert.ToString(reader["EmailAddress"]);
                    isCardLinked = Convert.ToBoolean(reader["IsCardLinked"]);
                    isCheckedIn = Convert.ToBoolean(reader["IsCheckedIn"]);
                    balance = Convert.ToInt32(reader["Balance"]);
                    foundVisitor = new Visitor(fullName, phone, mail, balance, rfidCode);
                    foundVisitor.IsCheckedIn = isCheckedIn;
                    foundVisitor.IsCardLinked = isCardLinked;
                }
            }
            catch (MySqlException)
            {
                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundVisitor;
        }

        private bool UpdateVisitorTableIsCheckedInColumn(string rfidCode, bool checkedIn)
        {
            bool onSuccess = false;

            string sql = "UPDATE visitor " +
            "SET IsCheckedIn = " + checkedIn +
             " WHERE RFID='" + rfidCode+"'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (command.ExecuteNonQuery() > 1)
                {
                    onSuccess = true;
                }

            }
            catch (MySqlException)
            {

                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Update IscheckedIn column value of database true or flase
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="foundVistor"></param>
        /// <returns></returns>
        public bool MakeCheckInOrOut(string rfidCode, out Visitor foundVistor)
        {
            foundVistor = FindVisitor(rfidCode);
            bool onSuccess = false;
            if(foundVistor!=null)
            {
               if(foundVistor.IsCheckedIn)
                {
                    foundVistor.IsCheckedIn = false;
                    onSuccess= UpdateVisitorTableIsCheckedInColumn(rfidCode, false);
                }
                else
                {
                    foundVistor.IsCheckedIn = true;
                    onSuccess= UpdateVisitorTableIsCheckedInColumn(rfidCode, true);
                }
            }
            return onSuccess;
        }

       

        public List<Visitor> GetAllVisitors()
        {
            String sql = "SELECT * FROM Visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Visitor> temp = new List<Visitor>();
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                int id;
                string name;
                string emailAddress;
                int phoneNumber;
                double balance;
                string rfid;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = Convert.ToString(reader["FullName"]);
                    emailAddress = Convert.ToString(reader["EmailAddress"]);
                    phoneNumber = Convert.ToInt32(reader["PhoneNumber"]);
                    balance = Convert.ToDouble(reader["Balance"]);
                    rfid = Convert.ToString(reader["RFID"]);
                    temp.Add(new Visitor(name, phoneNumber, emailAddress, balance, rfid));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the Visitors");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }
  
        public int AddVisitor(string name, string emailAddress, int phoneNumber, double balance, string rfid)
        { 
            String sql = "INSERT INTO visitor (FullName,EmailAddress,PhoneNumber,Balance,RFID)" +
                         "VALUES  (@FullName,@EmailAddress,@PhoneNumber,@Balance,@RFID )";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FullName", name);
            command.Parameters.AddWithValue("@EmailAddress", emailAddress);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@RFID", rfid);
            command.Parameters.AddWithValue("@Balance", balance);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion        
    }
}
