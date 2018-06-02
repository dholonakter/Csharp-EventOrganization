using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;
using Phidget22;
using Phidget22.Events;

namespace CampingApp
{
    public partial class CampingForm : Form
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

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        public CampingForm()
        {
            InitializeComponent();
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();

            // Switching delegate's method
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
            r = null;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();

            // Switching delegate's method
            myRFIDReader.Tag -= CheckIn;
            myRFIDReader.Tag += CheckOut;
            r = null;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            // Display data onto gridview
            campTable = new BindingSource();
            campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM reservation_info");
            dataGridViewCamp.DataSource = campTable;
            r = null;
        }

        private void CampingForm_Load(object sender, EventArgs e)
        {
            // Connecting to DB
            dh = new DataHelper();
            visitor = dh.FindVisitorByNr("10"); // DEMO

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Open();

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 

        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            visitor = dh.FindVisitorByTag(e.Tag);
            r = dh.FindReservationByVisitor(visitor);

            if (r != null)
            {
                display.DisplayReservation(r, lbCheckIn);

                DateTime endDate = DateTime.ParseExact(r.EndDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                if (r.Paid && DateTime.Compare(endDate, DateTime.Now) > 0) // if endDate is earlier than now
                {
                    display.SetText("OK", labelStatusIn);
                    r = null;
                }
                else
                {
                    display.SetText("NOT OK", labelStatusIn);
                }
            }
            else
            {
                MessageBox.Show("No reservation found");
            }
        }

        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            visitor = dh.FindVisitorByTag(e.Tag);
            r = dh.FindReservationByVisitor(visitor);

            if (r != null)
            {
                r.NrCheckedIn -= 1;
                if (dh.UpdateSelectedReservation(r) != -1)
                {
                    display.SetText("OK", labelStatusOut);
                    display.DisplayReservation(r, listBoxCheckOut); //update reservation info on lb
                    r = null;
                }
                else
                {
                    r.NrCheckedIn += 1; //revert
                    MessageBox.Show("Error while checking out");
                }
            }
            else
            {
                MessageBox.Show("No reservation found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (r != null)
            {
                r.ChangeStatus();
                if (dh.UpdateSelectedReservation(r) != -1)
                {
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText("OK", labelStatusIn);
                        display.DisplayReservation(r, lbCheckIn);
                        r = null;
                    }
                }
                else
                {
                    r.ChangeStatus(); // revert
                    MessageBox.Show("Error while updating status");
                }
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)campTable.DataSource))
            {
                MessageBox.Show("Data updated");
                dataGridViewCamp.Refresh();
            }
            else
            {
                MessageBox.Show("Error while updating data");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxMonitor.Items.Clear();
            r = dh.FindReservationByNr(textBoxResrvID.Text);
            if (r != null)
            {
                listBoxMonitor.Items.Add("RESERVATION #" + r.ReservNr);
                listBoxMonitor.Items.Add("Reserved: " + r.ReservDate + " " + r.ReservTime);
                listBoxMonitor.Items.Add("Reserver: " + r.Reserver.FirstName + ", " + r.Reserver.LastName);
                listBoxMonitor.Items.Add("Spot: Spot #" + r.Spot.SpotNr + " - " + r.Spot.SpotName);
                listBoxMonitor.Items.Add("Number of people: " + r.NrCheckedIn + "/" + r.NrOfRegistered);
                listBoxMonitor.Items.Add("Period: " + r.StartDate + " - " + r.EndDate);
                listBoxMonitor.Items.Add("Status: " + (r.Paid ? "PAID" : "NOT PAID"));
            }
            else
            {
                listBoxMonitor.Items.Add("Reservation not found");
            }
        }
    }
}
