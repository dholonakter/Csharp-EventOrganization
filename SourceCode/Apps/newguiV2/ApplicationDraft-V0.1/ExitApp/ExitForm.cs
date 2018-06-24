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
using System.Threading;

// webcam and qr
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using System.Media;

namespace EntranceApp
{
    public partial class ExitForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Ticket t;
        Visitor visitor;
        DataHelper dh;
        RFID myRFIDReader;
        bool admin;

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        // thanh tests qr
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();
        WebCam wCam;

        // thanh has some fun
        SoundPlayer successSound = new SoundPlayer("../../../connect.wav");
        SoundPlayer errorSound = new SoundPlayer("../../../error.wav");


        ///////////////////////////////////////
        // STARTUP STUFF
        ///////////////////////////////////////
        public void ShowAttached(object sender, AttachEventArgs e)
        {
            MessageBox.Show("RFID Reader Attached: Serial nr." + myRFIDReader.DeviceSerialNumber);
        }

        public void ShowDetached(object sender, DetachEventArgs e)
        {
            MessageBox.Show("RFID Reader Detached: Serial nr." + myRFIDReader.DeviceSerialNumber);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            // Connecting to DB
            dh = new DataHelper();

            // DEMO
            t = dh.GetTicket(3);
            visitor = dh.FindVisitorByNr(13);


            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowDetached);

                myRFIDReader.Open();

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }
        }

        ///////////////////////////////////////
        // GUI THINGS
        ///////////////////////////////////////
        public ExitForm()
        {
            InitializeComponent();
            admin = false;
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {

        }

      
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();

            // Switching delegate's method
            myRFIDReader.Tag -= ScanRFID;
            myRFIDReader.Tag += CheckOut;
            checkoutOverrideBtn.Text = "Override";
            admin = false;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            // Switching delegate's method

            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += ScanRFID;
        }

        ///////////////////////////////////////
        // SEARCH PANEL
        ///////////////////////////////////////

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();

            if (nameRbtn.Checked)
            {
                List<Visitor> visitors = dh.FindVisitorByName(textBoxSearch.Text);
                if (visitors.Count != 0)
                {
                    foreach (Visitor v in dh.FindVisitorByName(textBoxSearch.Text))
                    {
                        logsInfoLbx.Items.Add(v);
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No visitor found");
                }
            }
            else if (tagRbtn.Checked)
            {
                visitor = dh.FindVisitorByTag(textBoxSearch.Text);
                if (visitor != null)
                {
                    logsInfoLbx.Items.Add(visitor);
                }
                else
                {
                    logsInfoLbx.Items.Add("No visitor found");
                }
            }
            else if (ticketRbtn.Checked)
            {
                t = dh.GetTicket(Convert.ToInt32(textBoxSearch.Text));
                if (t != null)
                {
                    if (dh.FindVisitorByNr(t.BuyerNr) != null)
                    {
                        logsInfoLbx.Items.Add(visitor);
                    }
                    else
                    {
                        logsInfoLbx.Items.Add("No visitor found");
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No ticket found");
                }
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 
        private void ScanRFID(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag != null)
            {
                CrossThreadDisplay display = new CrossThreadDisplay(this);
                display.SetTextBox(e.Tag, textBoxSearch);
            }
        }

       
        

        ///////////////////////////////////////
        // CHECK OUT PANEL
        /////////////////////////////////////// 
        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            Visitor v = dh.FindVisitorByTag(e.Tag);

            dh.FindUnreturnedItems(v);

            if (!admin)
            {
                if (v.CanLeave())
                {
                    if (dh.MoveToDeletedVisitor(v) != -1)
                    {
                        display.SetText("OK", checkoutStatusLbl);
                        display.SetText("Visitor can exit", checkoutMessageLbl);
                        display.ChangeLabelColor(checkoutStatusLbl, Color.DarkGreen);
                    }
                    else
                    {
                        v.CheckInWith(visitor.RFIDNr); // undo the task
                        display.SetText("NOK", checkoutStatusLbl);
                        display.SetText("Error while checking out", checkoutMessageLbl);
                        display.ChangeLabelColor(checkoutStatusLbl, Color.DarkRed);
                    }
                }
                else
                {
                    display.DisplayLoanArticle(v.ArticlesBorrowed, checkoutInfoLbx);
                    display.SetText("NOK", checkoutStatusLbl);
                    display.SetText("Unreturned items found", checkoutMessageLbl);
                    display.ChangeLabelColor(checkoutStatusLbl, Color.DarkRed);
                }
            }
            else
            {
                if (dh.MoveToDeletedVisitor(v) != -1)
                {
                    display.SetText("OK", checkoutStatusLbl);
                    display.SetText("Visitor can exit", checkoutMessageLbl);
                    display.ChangeLabelColor(checkoutStatusLbl, Color.DarkGreen);
                }
                else
                {
                    v.CheckInWith(visitor.RFIDNr); // undo the task
                    display.SetText("NOK", checkoutStatusLbl);
                    display.SetText("Error while checking out", checkoutMessageLbl);
                    display.ChangeLabelColor(checkoutStatusLbl, Color.DarkRed);
                }
            }
            display.Dispose();
        }

        ///////////////////////////////////////
        // THANH TEST
        /////////////////////////////////////// 

       
      

        

      
      

        private void ShowUserDetails(ListBox lb)
        {
            if (visitor != null)
            {
                lb.Items.Clear();
                lb.Items.Add("VISITOR NR. " + visitor.IdNr);
                lb.Items.Add("Name: " + visitor.FirstName + ", " + visitor.LastName);
                lb.Items.Add("Phone: " + visitor.Phone);
                lb.Items.Add("Checked In: " + (visitor.CheckedIn ? "Yes" : "No"));
            }
        }

   

        // thanh has fun, but moderately
   

        private void CheckOutOverride(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in as admin");
            admin = true;
            checkoutOverrideBtn.Text = "Revoke admin rights";
            ((Form)sender).Close();
        }


    


        private void checkoutOverrideBtn_Click(object sender, EventArgs e)
        {
            if (!admin)
            {
                LoginForm testDialog = new LoginForm();
                testDialog.LoggedInHandler += CheckOutOverride;
                testDialog.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Revoke admin rights on this user?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    admin = false;
                    checkoutOverrideBtn.Text = "Override";
                }
            }
        }

        private void checkoutDetailsBtn_Click(object sender, EventArgs e)
        {
            ShowUserDetails(checkoutInfoLbx);
        }

        private void checkoutClearBtn_Click(object sender, EventArgs e)
        {
            checkoutInfoLbx.Items.Clear();
        }

        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Ticket> tickets = dh.GetUsedTickets();
            if (tickets.Count != 0)
            {
                foreach (Ticket t in tickets)
                {
                    logsInfoLbx.Items.Add("Ticket nr. " + t.TicketNr + "; Entry time: " + t.EntryTime + "; Type: " + t.TicketType + "; Price: €" + t.Price.ToString("0.00"));
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No tickets used");
            }
        }

        private void checkinLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Visitor> visitors = dh.FindCheckedInVisitors();
            if (visitors.Count != 0)
            {
                foreach (Visitor v in visitors)
                {
                    logsInfoLbx.Items.Add(v);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No tickets used");
            }
        }

        private void checkoutLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Visitor> visitors = dh.FindCheckedOutVisitors();
            if (visitors.Count != 0)
            {
                foreach (Visitor v in visitors)
                {
                    logsInfoLbx.Items.Add(v);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No tickets used");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
