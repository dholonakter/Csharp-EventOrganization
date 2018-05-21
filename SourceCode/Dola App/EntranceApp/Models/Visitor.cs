using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceApp
{
    public class Visitor
    {
        #region Properties
        public string FullName { get; set; }
        public string RFID { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public double Balance { get; }
        public bool IsCheckedIn { get; set; }
        public bool IsCardLinked { get; set; }
        #endregion

        #region constructor
        public Visitor(string name, int telephoneNumber, string emailaddress, double balance, string rfid)
        {
            this.FullName = name;
            this.PhoneNumber = telephoneNumber;
            this.EmailAddress = emailaddress;
            this.Balance = balance;
            this.RFID = rfid;
        }
        #endregion
    }
}