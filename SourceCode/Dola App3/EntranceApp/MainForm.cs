using System;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using System.Drawing;
using EntranceApp.Helper;
using EntranceApp.Models;

namespace EntranceApp
{
    public partial class MainForm : Form, ILogger
    {
        #region Public Constants
        public const string lblDefaultText = "...........................";
        #endregion

        #region Private Fields
        private DatabaseHelper dh;
        private RFID myRFIDReader;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            try
            {
                dh = new DatabaseHelper(this);
                myRFIDReader = new RFID();

            }
            catch (PhidgetException)
            {
                lbxLogMessage.Items.Add("startup: so far so good.");

            }
        }
        #endregion

        #region Private Methods
       
        #endregion

        #region Private Event Handlers Methods

        private void ShowErrorMessage(string message)
        {
            lblMessage.Text = "Cannot find visitor";
            lblMessage.BackColor = Color.Red;
        }
        private void ShowSuccessMessage(string message)
        {
            lblMessage.BackColor = Color.Green;
            lblMessage.Text = message;
        }
        private void ResetControlsBackColor()
        {
            lblMessage.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }
        private void SetLabelsTextOfCheckInCheckOutGroupBox(Visitor visitor)
        {
            if (visitor != null)
            {
                lblFullName.Text = visitor.FullName;
                lblEmailAddress.Text = visitor.EmailAddress;
                lblRFIDCode.Text = visitor.RFID;
                if (visitor.IsCheckedIn)
                {
                    ShowSuccessMessage("Check In Success");
                    btnCheckIn.BackColor = Color.Green;
                    btnCheckOut.BackColor = SystemColors.Control; 
                }
                else
                {
                    ShowSuccessMessage("Check Out Success");
                    btnCheckOut.BackColor = Color.Green;
                    btnCheckIn.BackColor = SystemColors.Control;
                }
            }
        }
        private void CheckIn (string rfid)//Rfid rfid)
        {
            if (!String.IsNullOrEmpty(rfid))//rfid != null)
            {
                Visitor checkinvisitor=new Visitor(rfid);

                if (dh.CheckIn(checkinvisitor))//rfid.Code, out checkedInVisitor))
                {
                    SetLabelsTextOfCheckInCheckOutGroupBox(checkinvisitor);
                    timerResetControls.Start();
                }
                else if (dh.Checkout(checkinvisitor))
                {
                    SetLabelsTextOfCheckInCheckOutGroupBox(checkinvisitor);
                    timerResetControls.Start();

                }
                else
                {
                    ResetControlsBackColor();
                    ShowErrorMessage("Cannot find vistor");
                    timerResetControls.Start();
                }
            }
        }

        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
               CheckIn(e.Tag);
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                LogMessage(ErrorType.RFID, "Open");
            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "No RFID-reader opened");
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            myRFIDReader.Tag -= new RFIDTagEventHandler(ProcessThisTag);
            myRFIDReader.Close();
            LogMessage(ErrorType.RFID, "Closed");
        }

        //private void TimerToResetControls_Tick(object sender, EventArgs e)
        //{
        //    if (isAllowedToLinkOrUnLinkCard)
        //    {
        //        ResetBuyTicketsGroupControls();
        //        isAllowedToLinkOrUnLinkCard = false;
        //    }
        //    else
        //    {
        //        ResetControls();
        //    }
        //    timerResetControls.Stop();
        //}
       
        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
          //  ResetBuyTicketsGroupControls();
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            lbxLogMessage.Items.Clear();
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbxLogMessage.Items.Add(errorType + ":" + message);
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
