using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApp
{
    class Visitor
    {
        // FIELDS + PROPERTIES
        // non-changable fields
        public int VisitorNr { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        // changeable fields
        public string RFIDNr { get; set; }
        public double Credit { get; set; }
        public bool CheckedIn { get; set; }
        public bool Paid { get; set; }
        public List<StoreArticle> ArticlesBorrowed { get; set; } // need for checking out

        // Constructors
        public Visitor (int nr, string first, string last, string phone, string mail, string rfidNr, double cred, bool checkedIn, bool paid)
        {
            this.VisitorNr = nr;
            this.FirstName = first;
            this.LastName = last;
            this.Phone = phone;
            this.Email = mail;
            this.RFIDNr = rfidNr;
            this.Credit = cred;
            this.CheckedIn = checkedIn;
            this.Paid = paid;
            ArticlesBorrowed = new List<StoreArticle>();
        }

        // Methods
        public override string ToString()
        {
            return "Visitor #" + this.VisitorNr + " - " + this.FirstName + " " + this.LastName + " - Phone: " + this.Phone
                + " - Credit: " + this.Credit + " - Checked in: " + this.CheckedIn.ToString() + " - RFID: " + this.RFIDNr + " - Paid: " + this.Paid;
        }
    }
}
