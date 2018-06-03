using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampEntranceApp
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalMember { get; set; }
        public int SpotNumber { get; set; }
        public int LocationNumber { get; set; }
        public string LeaderRFIDCode { get; set; }
        public bool IsPaid { get; set; }
        public Reservation(DateTime startDate, DateTime endDate, int totalnr, int spotNr, int locationNr, string rfid, bool isPaid)
        {
            StartDate = startDate;
            EndDate = endDate;
            TotalMember = totalnr;
            SpotNumber = spotNr;
            LocationNumber = locationNr;
            LeaderRFIDCode = rfid;
            IsPaid = isPaid;
        }
        public Reservation()
        {

        }

        public override string ToString()
        {
            return base.ToString() + StartDate + EndDate + TotalMember;
        }

    }
}
