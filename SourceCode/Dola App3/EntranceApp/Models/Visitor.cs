using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampReserVation
{
    public  abstract class Visitor
    {
        #region Properties
        public int Id { get; set; }
        public string FullName { get; set; }
        public string RFID { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public double Balance { get; }
        public bool IsCheckedIn { get; set; }
        public bool IsCardLinked { get; set; }
        #endregion

        #region constructor
        public Visitor(string rfid)
        {
            this.RFID = rfid;
        }
        public abstract double ExpenseFromEventAccount();
        public abstract double DepositeToEventAccount();
        #endregion
    }
}