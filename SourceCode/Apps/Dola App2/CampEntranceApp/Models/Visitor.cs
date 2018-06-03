using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampReserVation
{
    public class Visitor
    {
        #region Properties
        public int Id { get; set; }
        public string FullName { get; set; }
        public string RFID { get; set; }
        public double Balance { get; }
        public bool IsCheckedIn { get; set; }
        #endregion

        #region constructor
        public Visitor(string name,double balance ,string rfid)
        {
            this.FullName = name;
            this.Balance = balance;
            this.RFID = rfid;
        }
        #endregion
    }
}