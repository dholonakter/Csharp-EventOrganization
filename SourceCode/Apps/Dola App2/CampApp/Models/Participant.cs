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
        public int SpotNr { get; set; }
        public int ReservationId { get; set; }
        public Participant(string rfid,string fullname,double balance,bool isleader, int spotNr,int reservationId):base(fullname,rfid,balance)
        {
            IsLeader = isleader;
            SpotNr = spotNr;
            ReservationId = reservationId;
        }
        public Participant()
        {
                
        }
        public override string ToString()
        {
            return base.ToString() + IsLeader + " ," + ReservationId + " , " + SpotNr;

        }
    }
}
