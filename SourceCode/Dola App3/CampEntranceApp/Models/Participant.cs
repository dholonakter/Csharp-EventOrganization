using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampEntranceApp
{
    public class Participant : Visitor
    {
        public int SpotNr { get; set; }
        public Participant(string rfid, string firstName, string lastName, double balance, int spotNr) : base(firstName, lastName, rfid, balance)
        {
            SpotNr = spotNr;

        }
       // public ParticipantRole Role { get; set; }

        //public string LeaderRFIDCode { get; set; }

        //public Participant(string rfid, string fullname, double balance, ParticipantRole role, string leaderRFIDCode) : base(fullname, balance, rfid)
        //{
        //    Role = role;
        //    LeaderRFIDCode = leaderRFIDCode;
        //}
    }
}
