using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CampReserVation.Helper;

namespace CampReserVation.Database
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
                connection.Open();
                if (connection.Ping())
                {
                    LogMessage(ErrorType.Database, "Connected");
                    connection.Close();
                }
                else
                {
                    LogMessage(ErrorType.Database, "Cannot connect");
                }
            }
            catch
            {
              
                LogMessage(ErrorType.Database, "Something went wrong cannot connect");
                
            }
        }
        #endregion

        #region Private Methods
        private void LogMessage(ErrorType errorType, String message)
        {
            if (this.logger != null)
            {
                logger.LogMessage(errorType, message);
            }
        }

        public Visitor FindVisitor(string rfidCode)
        {
            Visitor foundVisitor = null;
            string sql = "SELECT * FROM visitor WHERE RFID ='" + rfidCode + "'";

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
                    mail = Convert.ToString(reader["EmailAddress"]);
                    phone = Convert.ToInt32(reader["PhoneNumber"]);
                    isCardLinked = Convert.ToBoolean(reader["IsCardLinked"]);
                    isCheckedIn = Convert.ToBoolean(reader["IsCheckedIn"]);
                    balance = Convert.ToInt32(reader["Balance"]);
                    foundVisitor = new Visitor(fullName, mail, phone, balance, rfidCode);
                    foundVisitor.IsCheckedIn = isCheckedIn;
                    foundVisitor.IsCardLinked = isCardLinked;
                    foundVisitor.Id = id;
                }
            }
            catch (MySqlException)
            {
                LogMessage(ErrorType.MySqlException, "Something went wrong while querying");
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
                if (command.ExecuteNonQuery() > 0)
                {
                    onSuccess = true;
                }

            }
            catch (MySqlException)
            {

                LogMessage(ErrorType.MySqlException, "Something went wrong while querying");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        
        #endregion

        /*
        private void change(ref Visitor visitor)
        {
            visitor.FullName = "";
        }
        */
        #region Public Methods
        /// <summary>
        /// Update IscheckedIn column value of database true or flase
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="foundVistor"></param>
        /// <returns></returns>
        public bool MakeCheckIn(Visitor foundVistor)
        {
            foundVistor = FindVisitor(foundVistor.RFID);            
            bool onSuccess = false;
            if(foundVistor!=null)
            {
               if(foundVistor.IsCheckedIn && foundVistor.IsCardLinked)
                {
                    foundVistor.IsCheckedIn = false;
                    onSuccess= UpdateVisitorTableIsCheckedInColumn(foundVistor.RFID, false);
                }
                else if(foundVistor.IsCardLinked)
                {
                    foundVistor.IsCheckedIn = true;
                    onSuccess= UpdateVisitorTableIsCheckedInColumn(foundVistor.RFID, true);
                }
            }
            return onSuccess;
        }
        public bool MakeCheckOut(Visitor foundVistor)
        {
            foundVistor = FindVisitor(foundVistor.RFID);
            bool onSuccess = false;
            if (foundVistor != null)
            {
                if (foundVistor.IsCheckedIn && foundVistor.IsCardLinked)
                {
                    foundVistor.IsCheckedIn = true;
                    onSuccess = UpdateVisitorTableIsCheckedInColumn(foundVistor.RFID, true);
                }
            }
            return onSuccess;
        }

       
           
        #endregion        
    }
}
