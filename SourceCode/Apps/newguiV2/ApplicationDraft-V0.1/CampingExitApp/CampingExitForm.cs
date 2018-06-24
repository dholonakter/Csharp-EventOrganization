using Phidget22;
using Phidget22.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThanhDLL;

namespace CampingApp
{
    public partial class CampingExitForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Visitor visitor;
        Reservation r;
        DataHelper dh;
        BindingSource campTable;
        RFID myRFIDReader;
        bool admin;

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

       

      

       

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();

            // Switching delegate's method
           

            myRFIDReader.Tag += CheckOut;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

        }

        private void CampingForm_Load(object sender, EventArgs e)
        {
            // Connecting to DB
            dh = new DataHelper();
            admin = false;

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Open();
                // Switching delegate's method
                myRFIDReader.Tag -= CheckOut;
                r = null;

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 


        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            visitor = dh.FindVisitorByTag(e.Tag);
            r = dh.FindReservationByVisitor(visitor);

            if (r != null)
            {
                if (visitor.IsInCamp)
                {
                    r.NrCheckedIn -= 1;
                    visitor.IsInCamp = false;
                    if (dh.UpdateSelectedReservation(r) != -1 && dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        display.DisplayReservation(r, checkoutInfoLbx);
                        display.SetText("OK", checkoutStatusLbl);
                        display.SetText("Checked out successful", checkoutMessageLbl);
                        r = null;
                    }
                    else
                    {
                        r.NrCheckedIn += 1; //revert
                        display.SetText("NOK", checkoutStatusLbl);
                        display.SetText("Please try scanning card again", checkoutMessageLbl);
                    }
                }
                else
                {
                    display.SetText("NOK", checkoutStatusLbl);
                    display.SetText("Already checked out", checkoutMessageLbl);
                }
            }
            else
            {
                display.SetText("No reservation found", checkoutMessageLbl);
            }
        }
        private void DisplayReservation(Reservation r, ListBox lb)
        {
            lb.Items.Clear();
            lb.Items.Add("RESERVATION NR. " + r.ReservNr);
            lb.Items.Add("Reserved on: " + r.ReservDate);
            lb.Items.Add("Reserved spot: " + r.Spot.SpotName);
            lb.Items.Add("Period: " + r.StartDate + " to " + r.EndDate);
            lb.Items.Add("Status: " + r.NrCheckedIn + "/" + r.NrOfRegistered + " checked in");
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            if (nameRbtn.Checked)
            {
                List<Visitor> visitors = dh.FindVisitorByName(textBoxSearch.Text);
                if (visitors.Count != 0)
                {
                    foreach (Visitor v in visitors)
                    {
                        r = dh.FindReservationByVisitor(v);
                        if (r != null)
                        {
                            logsInfoLbx.Items.Add("RESERVATION NR. " + r.ReservNr +
                            "; Reserved spot: " + r.Spot.SpotName +
                            "; Reserved by: " + r.Reserver.FirstName + ", " + r.Reserver.LastName.ToUpper());
                        }
                        else
                        {
                            logsInfoLbx.Items.Add("Cannot find reservation");
                        }
                    }
                }
                viewLogsBtn.Enabled = false;
                viewLogsBtn.BackColor = Color.LightGray;
            }
            else if (reservationRbtn.Checked)
            {
                r = dh.FindReservationByNr(textBoxSearch.Text);
                logsInfoLbx.Items.Add(r);
                viewLogsBtn.Enabled = true;
                viewLogsBtn.BackColor = Color.DimGray;
            }
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowUserDetails(ListBox lb)
        {
            if (visitor != null)
            {
                lb.Items.Clear();
                lb.Items.Add("VISITOR NR. " + visitor.IdNr);
                lb.Items.Add("Name: " + visitor.FirstName + ", " + visitor.LastName);
                lb.Items.Add("Phone: " + visitor.Phone);
                lb.Items.Add("Is In Camp: " + (visitor.IsInCamp ? "Yes" : "No"));
            }
        }

     

        private void checkoutDetailsBtn_Click(object sender, EventArgs e)
        {
            ShowUserDetails(checkoutInfoLbx);
        }

        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            
            if (r != null)
            {
                List<int> campersNr = dh.FindCampersNr(r);
                List<Visitor> visitors = new List<Visitor>();
                foreach (int number in campersNr)
                {
                    visitors.Add(dh.FindVisitorByNr(number));
                }
                for (int i = 0; i < visitors.Count; i++)
                {
                    logsInfoLbx.Items.Add("Nr. " + (i + 1) + ": " + visitors[i].FirstName + ", " + visitors[i].LastName.ToUpper()
                        + "; Phone: " + visitors[i].Phone);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("Please search for a reservation first");
            }
        }

        private void checkinLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Reservation> foundReservations = dh.FindFullyPresentReservations();
            if (foundReservations != null)
            {
                foreach (Reservation r in foundReservations)
                {
                    logsInfoLbx.Items.Add(r);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No reservation found");
            }

        }

        private void checkoutLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Reservation> foundReservations = dh.FindNotFullyPresentReservations();
            if (foundReservations != null)
            {
                foreach (Reservation r in foundReservations)
                {
                    logsInfoLbx.Items.Add(r);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No reservation found");
            }
        }


       
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
