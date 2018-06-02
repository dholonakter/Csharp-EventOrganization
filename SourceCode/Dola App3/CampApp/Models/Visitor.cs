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
        public double Balance { get; set; }
        public bool IsCheckedIn { get; set; }
        #endregion

        #region constructor
        public Visitor(string name,string rfid,double balance)
        {
            this.FullName = name;
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