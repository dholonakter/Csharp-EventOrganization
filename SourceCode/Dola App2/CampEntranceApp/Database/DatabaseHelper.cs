using CampReserVation.Helper;
using CampReserVation.Models;
using MySql.Data.MySqlClient;
using System;

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
        private void LoggingError(ErrorType errorType, String message)
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
                LoggingError(ErrorType.MySqlException, "Something went wrong while querying");
            }
            finally
            {
                connection.Close();
            }
            return foundVisitor;
        }


        public Participant FindParticipant(string rfidCode)
        {
            Participant foundParticipant = null;

            if (FindVisitor(rfidCode) != null)
            {
                string sql = "SELECT * FROM Participant WHERE RFID ='" + rfidCode + "'";
                int id;
                string rfid;
                int reservnr;
                string stratdate;
                string enddate;
                bool checkedin;
                int member;
                int nrofcheck;
                int spotNr;
                bool isleader;
                string groupType;
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = command.ExecuteReader();


                    // reading
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                        rfid = Convert.ToString(reader["RFID"]);
                        reservnr = Convert.ToInt32(reader["ReservationNr"]);
                        stratdate = Convert.ToString(reader["ReservationStartDate"]);
                        enddate = Convert.ToString(reader["ReserVationEndDate"]);
                        isleader = Convert.ToBoolean(reader["IsLeader"]);
                        checkedin = Convert.ToBoolean(reader["CheckedIn"]);
                        spotNr = Convert.ToInt32(reader["SpotNr"]);
                        member = Convert.ToInt32(reader["TotalMember"]);
                        nrofcheck = Convert.ToInt32(reader["NrOfCheckedIn"]);
                        groupType = Convert.ToString(reader["GroupType"]);

                        foundParticipant = new Participant(rfid, reservnr, stratdate, enddate,isleader, checkedin, member, nrofcheck, spotNr, groupType);
                        foundParticipant.ID = id;
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

            }
            return foundParticipant;


        }
        public bool AddParticipant(string rfid,  int reservnr,  string stratdate, string enddate, bool isleader, bool checkedin, int member,int nrofcheck,int spotnr,string groupType)
        {
            bool onSuccess = false;
            Participant foundparticipant = FindParticipant(rfid);


            if (foundparticipant == null)
            {
                String sql = "INSERT INTO visitor (RFID,ReservationNr,ReservationStartDate,ReservationEndDate,IsLeader,CheckedIn,SpotNr,GroupType)" +
                              "VALUES  (@RFID,@ReservationNr,@ReservationStartDate,@ReservationEndDate,@IsLeader,@CheckedIn,@SpotNr,@GroupType)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@RFID", rfid);
                command.Parameters.AddWithValue("@ReservationNr", reservnr);
                command.Parameters.AddWithValue("@ReservationStartDate", stratdate);
                command.Parameters.AddWithValue("@ReservationEndDate", enddate);
                command.Parameters.AddWithValue("@IsLeader", isleader);
                command.Parameters.AddWithValue("@CheckedIn", checkedin);
                command.Parameters.AddWithValue("@CheckedIn", checkedin);
                command.Parameters.AddWithValue("@SpotNr", spotnr);
                command.Parameters.AddWithValue("@GroupType", groupType);


                try
                {

                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        onSuccess = true; //UpdateRfidTableIsCardLinkedColumn(rfid, linkCard);
                    }


                }
                catch
                {
                    LoggingError(ErrorType.MySqlException, "AddVisitor: Error while adding visitor");
                }
                finally
                {
                    connection.Close();
                }
            }
            return onSuccess;
             }
        public bool UpdateVisitorTableBalanceColumn(string rfidcode,double balance)
        {
            return false;
        }


            
              





        #endregion


        #region Public Methods
        /// <summary>
        /// Update IscheckedIn column value of database true or flase
        /// </summary>
        /// <param name="rfidCode"></param>
        /// <param name="foundVistor"></param>
        /// <returns></returns>
        public bool CheckIn(Participant participant)
        {
            bool onSuccess = false;
            return onSuccess;
        }
        public bool CheckOut(Visitor foundVistor)
        {
            bool onSuccess = false;
            return onSuccess;
        }

       
           
        #endregion        
    }
}
