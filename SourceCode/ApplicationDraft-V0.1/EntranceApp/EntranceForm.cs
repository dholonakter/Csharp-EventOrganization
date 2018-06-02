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
    public partial class EntranceForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Ticket t;
        Visitor visitor;
        DataHelper dh;
        BindingSource visitorTable;
        RFID myRFIDReader;

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
            visitor = dh.FindVisitorByNr("4"); // DEMO

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
        public EntranceForm()
        {
            InitializeComponent();
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
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

            // Switching delegate's method
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();

            // Switching delegate's method
            myRFIDReader.Tag -= CheckIn;
            myRFIDReader.Tag += CheckOut;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            // Display data onto gridview
            visitorTable = new BindingSource();
            visitorTable.DataSource = dh.DataTableFromSQL("SELECT * FROM VISITOR");
            dataGridVisitor.DataSource = visitorTable;
        }

        ///////////////////////////////////////
        // SEARCH PANEL
        ///////////////////////////////////////
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)visitorTable.DataSource))
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
            labelMonitor.Text = "";
            int i;
            if (int.TryParse(textBoxSearch.Text, out i))
            {
                visitor = dh.FindVisitorByNr(i.ToString());
                if (visitor != null)
                {
                    labelMonitor.Text = visitor.ToString();
                }
                else
                {
                    MessageBox.Show("Visitor not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 

        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            if (visitor != null) // if there's a visitor
            {
                if (dh.existsRFID(e.Tag) == null)
                {
                    visitor.CheckInWith(e.Tag);

                    if (dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                        {
                            display.SetText(e.Tag, labelTagNr);
                        }

                        successSound.Play();
                    }
                    else
                    {
                        visitor.CheckOut(); // undo the task
                        MessageBox.Show("Error while checking in");
                    }
                }
                else
                {
                    MessageBox.Show("RFID already used");
                }
                StartWebcam(); // restart webcam
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

            if (v.CanLeave())
            {
                if (dh.MoveToDeletedVisitor(v) != -1)
                {
                    display.SetText("OK", labelStatusOut);
                }
                else
                {
                    v.CheckInWith(visitor.RFIDNr); // undo the task
                    MessageBox.Show("Error while checking out");
                }
            }
            else
            {
                errorSound.Play();
                display.DisplayLoanArticle(v.ArticlesBorrowed, lbCheckOut);
                display.SetText("NOT OK", labelStatusOut);
            }
            display.Dispose();
        }

        ///////////////////////////////////////
        // THANH TEST
        /////////////////////////////////////// 

        private void StartWebcam()
        {
            wCam = new WebCam { Container = pictureBoxSource };
            wCam.OpenConnection();
            webCamTimer = new System.Windows.Forms.Timer();
            webCamTimer.Tick += webCamTimer_Tick;
            webCamTimer.Interval = 200;
            webCamTimer.Start();
            labelStatusIn.Text = "No QR";
            lbCheckIn.Text = "No ticket found";
        }

        private void StopWebcam()
        {
            webCamTimer.Stop();
            webCamTimer = null;
            wCam.Dispose();
            wCam = null;
        }

        private void webCamTimer_Tick(object sender, EventArgs e)
        {
            var bitmap = wCam.GetCurrentImage();
            if (bitmap == null)
                return;
            var reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            CrossThreadDisplay display = new CrossThreadDisplay(this);

            if (result != null)
            {
                // Find their ticket
                t = dh.GetTicketStatusForVisitor(Convert.ToInt32(result.Text));
                visitor = dh.FindVisitorByNr(t.BuyerNr.ToString());

                if (t != null) // if ticket exists
                {
                    display.SetText(t.ToString(), lbCheckIn);

                    if (t.Paid)
                    {
                        display.SetText("OK", labelStatusIn);
                        StopWebcam();
                        t = null;
                    }
                    else
                    {
                        errorSound.Play();
                        display.SetText("UNPAID", labelStatusIn);
                    }
                }
                else
                {
                    MessageBox.Show("Ticket not found");
                }
            }
            else
            {
                labelStatusIn.Text = "No QR";
            }
        }

        private void buttonStartWC_Click(object sender, EventArgs e)
        {
            if (wCam == null)
            {
                StartWebcam();

            }
            else
            {
                StopWebcam();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.ChangeStatus();
                if (dh.UpdateSelectedTicket(t) != -1)
                {
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText("OK", labelStatusIn);
                    }
                }
                else
                {
                    t.ChangeStatus(); // revert
                    MessageBox.Show("Error while updating status");
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please enter a number");
        }
    }
}
