 using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using EntranceApp.Helper;
using System.Drawing;
using System.Threading;

namespace EntranceApp
{
    public partial class MainForm : Form,ILogger
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

        #region Private Event Handlers Methods
        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            AssignRFIDCodeToTextBox(e.Tag);
            Visitor  checkedInVisitor;
            if(dh.MakeCheckInOrOut(e.Tag, out checkedInVisitor))
            {
                if (checkedInVisitor != null)
                {
                    lblFullName.Text = checkedInVisitor.FullName;
                    lblEmailAddress.Text = checkedInVisitor.EmailAddress;
                    lblRFIDCode.Text = e.Tag;
                    lblMessage.BackColor = Color.Green;
                    lblMessage.Text = "Success";
                    if (checkedInVisitor.IsCheckedIn)
                    {
                        btnCheckIn.BackColor = Color.Green;
                        btnCheckOut.BackColor = SystemColors.Control;
                        timerResetControls.Start();
                       // ResetControls();
                    }
                    else
                    {
                        btnCheckOut.BackColor = Color.Green;
                        btnCheckIn.BackColor = SystemColors.Control;
                        timerResetControls.Start();
                        //ResetControls();
                    }
                }
            }
            else
            {
                lblMessage.BackColor = SystemColors.Control;
                btnCheckIn.BackColor = SystemColors.Control;
                btnCheckOut.BackColor = SystemColors.Control;
                lblMessage.Text = "UnSuccess";
            }
        }
        private void ResetControls()
        {
            lblFullName.Text = lblDefaultText;
            lblEmailAddress.Text = lblDefaultText;
            lblRFIDCode.Text = lblDefaultText;
            lblMessage.Text = lblDefaultText;
            lblMessage.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }
        private void AssignRFIDCodeToTextBox(string rfidCode)
        {
            if (rbtnLinkCard.Checked || rbtnUnLinkCard.Checked)
            {
                tbrfid.Text = rfidCode;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                lbxLogMessage.Items.Add("Open");
            }
            catch (PhidgetException) { lbxLogMessage.Items.Add("No RFID-reader opened"); }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            myRFIDReader.Tag -= new RFIDTagEventHandler(ProcessThisTag);
            myRFIDReader.Close();
            lbxLogMessage.Items.Add("Closed ");
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbxLogMessage.Items.Add(errorType+":"+message);
        }
        #endregion

        private void timerResetControls_Tick(object sender, EventArgs e)
        {
            ResetControls();
            timerResetControls.Stop();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {

        }
    }
}
