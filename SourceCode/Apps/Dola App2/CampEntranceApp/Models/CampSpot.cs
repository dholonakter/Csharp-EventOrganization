using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampReserVation.Models
{
 public class CampSpot

      {
        public int SpotNr { get; set; }
        public string SpotName { get; set; }
        public bool IsSpotFree { get; set; }
        public int SpotAvaialble{ get; set; }
        public int SpotBooked { get; set; }

        public CampSpot(int spotnr,string spotname,bool isSpotfree,int spotAvailable,int spotbooked)
        {
            this.SpotNr = spotnr;
            this.SpotName = spotname;
            this.IsSpotFree = isSpotfree;
            this.SpotAvaialble = spotAvailable;
            this.SpotBooked = spotbooked;
        }

        

    }
}
