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

namespace EntranceApp
{
    public partial class EntranceForm : Form
    {
        Visitor visitor;
        DataHelper dh;
        BindingSource visitorTable;
        RFID myRFIDReader;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);
        public ProcessTag tagProcessor;

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

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowDetached);

                tagProcessor += CheckIn; // by default checking in, but will change
                myRFIDReader.Tag += new RFIDTagEventHandler(tagProcessor); // add delegate to handler

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }
        }

        ///////////////////////////////////////
        // GUI THINGS
        ///////////////////////////////////////
        public EntranceForm()
        {
            InitializeComponent();
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
            ticketPanel.BringToFront();
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
            ticketPanel.BringToFront();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            visitorTable = new BindingSource();
            visitorTable.DataSource = dh.LoadVisitors();
            dataGridVisitor.DataSource = visitorTable;
        }

        ///////////////////////////////////////
        // SEARCH PANEL
        ///////////////////////////////////////
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (dh.UpdateVisitorsTable((DataTable)visitorTable.DataSource))
            {
                MessageBox.Show("Data updated");
                dataGridVisitor.Refresh();
            }
            else
            {
                MessageBox.Show("Error while updating data");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            visitor = dh.FindVisitorByNr(textBoxVisitorNrSearch.Text);
            if (visitor != null)
            {
                listBoxSearch.Items.Add(visitor);
            }
            else
            {
                MessageBox.Show("Visitor not found");
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 
        private void checkinPanel_Paint(object sender, PaintEventArgs e)
        {
            // Switchy switch
            tagProcessor -= CheckOut;
            tagProcessor += CheckIn;

            /* DEMO CODE */
            visitor = dh.FindVisitorByNr("10");
            Ticket t = dh.GetTicketStatusForVisitor(visitor.IdNr);

            // Display them info
            lbCheckIn.Items.Clear();
            lbCheckIn.Items.Add("TICKET #" + t.TicketNr);
            lbCheckIn.Items.Add("Bought: " + t.TicketDate + " " + t.TicketTime);
            lbCheckIn.Items.Add("Type: " + t.TicketType);
            lbCheckIn.Items.Add("Status: " + (t.Paid ? "PAID" : "NOT PAID"));

            if (t != null) // if ticket exists
            {
                if (t.Paid)
                {
                    visitor.CheckInWith("testcheckingin");
                    if (dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        labelTag.Text = "testcheckingin";
                        labelStatusIn.Text = "OK";
                    }
                    else
                    {
                        visitor.CheckOut(); // undo the task
                    }

                }
                else
                {
                    labelStatusIn.Text = "UNPAID";
                }
            }
            else
            {
                MessageBox.Show("Your ticket is not valid");
            }
        }
        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            // TO DO: Read QR Code to get visitor Nr //
            Ticket t = dh.GetTicketStatusForVisitor(visitor.IdNr);

            // Display them info
            lbCheckIn.Items.Clear();
            lbCheckIn.Items.Add("TICKET #" + t.TicketNr);
            lbCheckIn.Items.Add("Bought: " + t.TicketDate + " " + t.TicketTime);
            lbCheckIn.Items.Add("Type: " + t.TicketType);
            lbCheckIn.Items.Add("Status: " + (t.Paid ? "PAID" : "NOT PAID"));

            if (t != null) // if ticket exists
            {
                if (t.Paid)
                {
                    visitor.CheckInWith("testcheckingin");
                    if (dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        labelTag.Text = "testcheckingin";
                        labelStatusIn.Text = "OK";
                    }
                    else
                    {
                        visitor.CheckOut(); // undo the task
                    }

                }
                else
                {
                    labelStatusIn.Text = "UNPAID";
                }
            }
            else
            {
                MessageBox.Show("Your ticket is not valid");
            }
        }

        ///////////////////////////////////////
        // CHECK OUT PANEL
        /////////////////////////////////////// 
        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            dh.FindUnreturnedItems(visitor);

            if (visitor.CanLeave())
            {
                visitor.CheckOut();
                if (dh.UpdateSelectedVisitor(visitor) != -1)
                {
                    labelStatusOut.Text = "OK";
                }
                else
                {
                    visitor.CheckInWith(visitor.RFIDNr); // undo the task
                }
            }
            else
            {
                labelStatusOut.Text = "NOT OK";
                foreach (LoanArticle a in visitor.ArticlesBorrowed)
                {
                    lbCheckOut.Items.Add("Article #" + a.ArticleNr + " - " + a.ArticleName + " at " + a.ShopName);
                }
            }

        }

        private void checkoutPanel_Paint(object sender, PaintEventArgs e)
        {
            // Switchy switch
            tagProcessor -= CheckIn;
            tagProcessor += CheckOut;

            /* DEMO CODE */
            visitor = dh.FindVisitorByNr("4");
            dh.FindUnreturnedItems(visitor);

            if (visitor.CanLeave())
            {
                visitor.CheckOut();
                if (dh.UpdateSelectedVisitor(visitor) != -1)
                {
                    labelStatusOut.Text = "OK";
                }
                else
                {
                    visitor.CheckInWith(visitor.RFIDNr); // undo the task
                }
            }
            else
            {
                labelStatusOut.Text = "NOT OK";
                lbCheckOut.Items.Clear();

                foreach (LoanArticle a in visitor.ArticlesBorrowed)
                {
                    lbCheckOut.Items.Add("Article #" + a.ArticleNr + " - " + a.ArticleName + " at " + a.ShopName);
                }
            }
        }


    }
}
