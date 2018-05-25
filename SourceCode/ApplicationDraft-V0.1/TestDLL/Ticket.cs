using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhDLL
{
    public class Ticket
    {
        /// <summary>
        /// Class to hold Ticket's information
        /// </summary>

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        public int TicketNr { get; set; }
        public string TicketDate { get; set; }
        public string TicketTime { get; set; }
        public int BuyerNr { get; set; }
        public string TicketType { get; set; }
        public bool Paid { get; set; }

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public Ticket(int ticketNr, string date, string time, int buyer, string type, bool paid)
        {
            this.TicketNr = ticketNr;
            this.TicketDate = date;
            this.TicketTime = time;
            this.BuyerNr = buyer;
            this.TicketType = type;
            this.Paid = paid;
        }

        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////

        /// <summary>
        /// Returns ticket's information as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Ticket #" + this.TicketNr + " - " + this.TicketDate + " " + this.TicketTime +
                " Type: " + this.TicketType + " - Buyer: " + this.BuyerNr + " - " + (Paid ? "PAID" : "NOT PAID");
        }
    }
}
