using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampEntranceApp
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
        #endregion

      #region public Method
        /// <summary>
        /// read data from visitor
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <returns></returns>
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
                string firstname;
                string lastName;
                int phone;
                string mail;
                bool isCheckedIn;
                double balance;
                // reading
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["VisitorNr"]);
                    firstname = Convert.ToString(reader["FirstName"]);
                    lastName = Convert.ToString(reader["lastName"]);
                    mail = Convert.ToString(reader["Email"]);
                    phone = Convert.ToInt32(reader["PhoneNumber"]);
                    isCheckedIn = Convert.ToBoolean(reader["CheckedIn"]);
                    balance = Convert.ToInt32(reader["Balance"]);
                    foundVisitor = new Visitor(firstname, lastName, rfidCode,balance);
                    foundVisitor.IsCheckedIn = isCheckedIn;
                    foundVisitor.Id = id;
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
        /// <summary>
        /// update the checkin column to the visitor
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="checkedIn"></param>
        /// <returns></returns>
        private bool UpdateParticipantTableIsCheckedInColumn(string rfidCode, bool checkedIn)
        {
            bool onSuccess = false;

            string sql = "UPDATE participant " +
            "SET CheckedIn = " + checkedIn +
             " WHERE RFID='" + rfidCode + "'";

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

                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");

            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }



    }
    #endregion


}
