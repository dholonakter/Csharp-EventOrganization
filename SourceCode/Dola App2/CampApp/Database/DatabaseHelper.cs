using CampReserVation.Helper;
using CampReserVation.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

       
        private bool AddToParticipantTable()
        {
            bool onSuccess = false;
            String sql = "INSERT INTO reservation (ReservationId,Start_Date,End_Date,TotalNumber)" +
              "VALUES  (@ParticipantId,@Participant_Name,@RFID,@ReservationId,@SpotNumber,@IsLeader,@CheckedIn)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            Participant participant = new Participant();
            command.Parameters.AddWithValue("@ParticipantId", participant.Id);
            command.Parameters.AddWithValue("@Participant_Name", participant.FullName);
            command.Parameters.AddWithValue("@RFID", participant.RFID);
            command.Parameters.AddWithValue("@ReservationId", participant.ReservationId);
            command.Parameters.AddWithValue("@SpotNumber", participant.SpotNr);
            command.Parameters.AddWithValue("@IsLeader", participant.IsLeader);
            command.Parameters.AddWithValue("@CheckedIn", participant.IsCheckedIn);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    onSuccess = true;
                }


            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "Reservation: Error while adding visitor");
            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        private bool AddToReserverationTable(Reservation reservationAdd)
        {
            bool onSuccess = false;
            String sql = "INSERT INTO reservation (ReservationId,Start_Date,End_Date,TotalNumber)" +
              "VALUES  (@ReservationId,@Start_Date,@End_Date,@SpotNumber,@TotalNumber)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ReservationId", reservationAdd.ReservationStartDate);
            command.Parameters.AddWithValue("@Start_Date", reservationAdd.ReservationEndDate);
            command.Parameters.AddWithValue("@End_Date", reservationAdd.SpotNr);
            command.Parameters.AddWithValue("@SpotNumber", reservationAdd.Id);
            command.Parameters.AddWithValue("@TotalNumber", reservationAdd.Id);



            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    onSuccess = true;
                }


            }
            catch
            {
                LogMessage(ErrorType.MySqlException, "Reservation: Error while adding visitor");
            }
            finally
            {
                connection.Close();
            }
            return onSuccess;
        }

        #endregion

        #region Public Methods
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
                    foundVisitor = new Visitor(fullName, rfidCode,balance);
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


        public bool UpdateVisitorTableBalanceColumn(string rfidcode, double balance)
        {
            return false;
        }

        public bool CampReservation(Reservation reservationAdd)
        {
            bool onSucess = false;
            onSucess = AddToReserverationTable(reservationAdd);
            onSucess = AddToParticipantTable();
            return onSucess;
        }


        public List<CampSpot> GetAllSpotName()
        {
            string sql = "select * from camp_spot";
            List<CampSpot> getAllSpotName = new List<CampSpot>();
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string spotname;
                    int locationId;
                    spotname = Convert.ToString(reader["SpotName"]);
                    locationId = Convert.ToInt32(reader["LocationNr"]);
                    CampSpot campSpot = new CampSpot();
                    campSpot.Name = spotname;
                    campSpot.LocationId = locationId;
                    getAllSpotName.Add(campSpot);
                }
                return getAllSpotName;
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
            return getAllSpotName;
        }
        public Location GetLocation(int locationId)
        {
            string sql = "select * from camp_location where LocationNr='"+locationId+"'";
            Location foundLocation = null;
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string Locationname;
                    Locationname = Convert.ToString(reader["LocationName"]);
                    foundLocation = new Location
                    {
                        LocationId=locationId,
                        LocationName = Locationname
                    };
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
            return foundLocation;
        }
    }

}


    #endregion



