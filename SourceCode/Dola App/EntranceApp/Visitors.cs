using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceApp
{
    public class Visitors
    {
        private int _id;
        private int _rfid;
        private double balance;
        public int Id { get; }
        public string FullName { get; set; }
        public int RFID { get; }
        public int TelephonNumber { get; set; }
        public string EmailAddress { get; set; }
        public double Balance { get; }



        public Visitors(int id, string name, int rfid,string fullname,int telephoneNumber,string emailaddress,double balance)
        {
            this.Id = id;
            this.FullName = name;
            this.RFID = rfid;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}