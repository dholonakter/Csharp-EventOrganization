using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampEntranceApp
{
    public class Visitor
    {
        #region Properties
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Phone { get; set; }
        public string RFID { get; set; }
        public double Balance { get; set; }
        public bool IsCheckedIn { get; set; }
        #endregion

        #region constructor
        public Visitor(string firstname,string lastname,string rfid,double balance)
        {
            this.FirstName = firstname;
            this.FirstName = firstname;
            this.RFID = rfid;
            this.Balance = balance;
        }
        public Visitor()
        {

        }
        public override string ToString()
        {
            return FullName + "," + Balance + "," + RFID;

        }
        #endregion
    }
}