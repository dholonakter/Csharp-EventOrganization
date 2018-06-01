using CampReserVation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampReserVation.Models
{
 public  class Participant:Visitor
    {
        public bool IsLeader { get; set; }
        public int ReservationNr { get; set; }
        public int SpotNr { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public int TotalMember { get; set; }
        public string GroupType { get; set; }
        public Participant(string rfid,string fullname,int reservnr, DateTime startdate, DateTime enddate,bool isleader, bool checkedin, int member, int spotNr,string grouptype,double balance):base(fullname,balance,rfid)
        {
            ReservationNr = reservnr;
            ReservationStartDate = startdate;
            ReservationEndDate = enddate;
            TotalMember = member;
            SpotNr = spotNr;
            GroupType = grouptype;

        }
    }
}
