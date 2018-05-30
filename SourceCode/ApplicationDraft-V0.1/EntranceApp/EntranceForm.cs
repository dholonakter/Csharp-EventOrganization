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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Media;

namespace EntranceApp
{
    public partial class EntranceForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Visitor visitor;
        DataHelper dh;
        BindingSource visitorTable;
        RFID myRFIDReader;
        
        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        // thanh tests qr
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();
        WebCam wCam;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap capturedImage;
        private String message = "";

        // thanh has  some fun
        SoundPlayer successSound = new SoundPlayer("../../../connect.wav");
        SoundPlayer errorSound = new SoundPlayer("../../../error.wav");


        ///////////////////////////////////////
        // CROSS-THREAD DISPLAY
        ///////////////////////////////////////

        // Delegates for cross-thread processing
        delegate void LabelDelegate(string text, Label lb);
        delegate void ListboxDelegate(Object o, ListBox lb);

        // Set text to label
        private void SetText(string text, Label lb)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (lb.InvokeRequired)
            {
                LabelDelegate d = new LabelDelegate(SetText);
                this.Invoke(d, new object[] { text, lb});
            }
            else
            {
                lb.Text = text;
            }
        }

        // Display a ticket in a given listbox
        private void DisplayTicket(Object o, ListBox lb)
        {
            Ticket t = (Ticket)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayTicket);
                this.Invoke(d, new object[] { t, lb });
            }
            else
            {
                // Display them info
                lb.Items.Clear();
                lb.Items.Add("TICKET #" + t.TicketNr);
                lb.Items.Add("Bought: " + t.TicketDate + " " + t.TicketTime);
                lb.Items.Add("Type: " + t.TicketType);
                lb.Items.Add("Status: " + (t.Paid ? "PAID" : "NOT PAID"));
            }
        }

        // Display an article in a given listbox
        private void DisplayArticle(Object o, ListBox lb)
        {
            List<LoanArticle> list = (List<LoanArticle>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                this.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (LoanArticle a in list)
                {
                    lb.Items.Add(a);
                }
            }
        }

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

            // thanh tests qr
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameraSource.Items.Add(device.Name);
            }
            comboBoxCameraSource.SelectedIndex = 0;

            videoSource = new VideoCaptureDevice();

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

        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            // TO DO: Read QR Code to get visitor Nr //
            Ticket t = dh.GetTicketStatusForVisitor(visitor.IdNr);
            
            if (t != null) // if ticket exists
            {
                DisplayTicket(t, lbCheckIn);

                if (t.Paid)
                {
                    if (dh.existsRFID(e.Tag) == null)
                    {
                        visitor.CheckInWith(e.Tag);

                        if (dh.UpdateSelectedVisitor(visitor) != -1)
                        {
                            SetText("OK", labelStatusIn);
                            SetText(e.Tag, labelTagNr);
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

                }
                else
                {
                    errorSound.Play();
                    SetText("UNPAID", labelStatusIn);
                }
            }
            else
            {
                MessageBox.Show("Ticket not found");
            }
        }

        ///////////////////////////////////////
        // CHECK OUT PANEL
        /////////////////////////////////////// 
        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            Visitor v = dh.FindVisitorByTag(e.Tag);
            dh.FindUnreturnedItems(v);

            if (v.CanLeave())
            {
                if (dh.MoveToDeletedVisitor(v) != -1)
                {
                    SetText("OK", labelStatusOut);
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
                DisplayArticle(v.ArticlesBorrowed, lbCheckOut);
                SetText("NOT OK", labelStatusOut);
            }

        }

        ///////////////////////////////////////
        // THANH TEST
        /////////////////////////////////////// 
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxSource.Image = image;
        }

        private string ReadQR(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader
                    (null, newbitmap => new BitmapLuminanceSource(bitmap), luminance => new GlobalHistogramBinarizer(luminance));

                reader.AutoRotate = true;
                reader.TryInverted = true;
                reader.Options = new DecodingOptions { TryHarder = true };

                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    message = result.Text;
                    return message;
                }
                else
                {
                    message = "QRCode couldn't be decoded.";
                    return message;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (capturedImage != null)
            {
                label2.Text = ReadQR(capturedImage);
            }*/
            try
            {
                Bitmap bitmap = new Bitmap(pictureBoxSource.Image);
                BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
                Result result = reader.Decode(bitmap);
                string decoded = result.ToString().Trim();
                label2.Text = decoded;
                // DEMO BUT ALSO KINDA WILL KEEP
                visitor = dh.FindVisitorByNr(decoded);
                label3.Text = visitor.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (videoSource.IsRunning)
            {
                pictureBoxCaptured.Image = (Bitmap)pictureBoxSource.Image.Clone();
                capturedImage = (Bitmap)pictureBoxCaptured.Image;
            }*/
            
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                pictureBoxSource.ImageLocation = open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBoxSource.Image = null;
                pictureBoxCaptured.Image = null;
                pictureBoxSource.Invalidate();
                pictureBoxCaptured.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameraSource.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            /*
            if (wCam == null)
            {
                wCam = new WebCam { Container = pictureBoxSource };

                wCam.OpenConnection();

                webCamTimer = new System.Windows.Forms.Timer();
                webCamTimer.Tick += webCamTimer_Tick;
                webCamTimer.Interval = 100;
                webCamTimer.Start();
            }
            else
            {
                webCamTimer.Stop();
                webCamTimer = null;
                wCam.Dispose();
                wCam = null;
            }*/
        }

        private void webCamTimer_Tick(object sender, EventArgs e)
        {
            var bitmap = wCam.GetCurrentImage();
            if (bitmap == null)
                return;
            var reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                //txtTypeWebCam.Text = result.BarcodeFormat.ToString();
                MessageBox.Show(result.Text);
            }

            else
            {
                label2.Text = "NULL";
            }
        }
    }
}
