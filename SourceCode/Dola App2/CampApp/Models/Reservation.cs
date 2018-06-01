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

        public override string ToString()
        {
            return base.ToString() + ReservationStartDate + ReservationEndDate + TotalMember;
        }

    }
}
