using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampReserVation.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public int TotalMember { get; set; }
        public int SpotNr { get; set; }
        public int LocationNr { get; set; }
        public string RFID { get; set; }
        public bool IsPaid { get; set; }
        public Reservation(DateTime startDate,DateTime endDate,int totalnr)
        {
            ReservationStartDate = startDate;
            ReservationEndDate = endDate;
            TotalMember = totalnr;
        }
        public Reservation()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ReservationStartDate + ReservationEndDate + TotalMember;
        }

    }
}
