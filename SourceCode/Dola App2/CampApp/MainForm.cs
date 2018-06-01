using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using CampReserVation.Helper;
using CampReserVation.Database;
using CampReserVation.Models;

namespace CampReserVation
{
    public partial class CampRegistrationForm : Form, ILogger
    {
        #region Private Fields
        private RFID myRFIDReader;
        private DatabaseHelper databaseHelper;
        #endregion

        #region Constructor
        public CampRegistrationForm()
        {
            InitializeComponent();
            try
            {
                databaseHelper = new DatabaseHelper(this);
                myRFIDReader = new RFID();
                

            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "startup: so far so good.");
            }
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbMembers.Items.Add(errorType + ":" + message);
        }
        private void ResetBuyTicketsGroupControls()
        {
            lblFulName.Text = string.Empty;
            lblrfid.Text = string.Empty;
            lblCurrentBalance.Text = string.Empty;
        
        }

        public void GetInfoFromVisitor(string rfid)
        {
            Visitor getvisitor = databaseHelper.FindVisitor(rfid);
            if (getvisitor != null)
            {
                lblFulName.Text = getvisitor.FullName;
                lblrfid.Text = getvisitor.RFID;
                lblCurrentBalance.Text = getvisitor.Balance.ToString();
            }
            else
            {
                ResetBuyTicketsGroupControls();
               lblReserveMessage.Text="Invalid card";
            }
            
        }
        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            
                GetInfoFromVisitor(e.Tag);

        }

        #endregion

        # region Event
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                LogMessage(ErrorType.RFID, "Open");
                
                cbxSpotName.Items.AddRange(databaseHelper.GetAllSpotName().ToArray());
                //comboBox3.Items.AddRange(databaseHelper.GetAllLocationName().ToArray());


            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "No RFID-reader opened");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myRFIDReader.Tag -= new RFIDTagEventHandler(ProcessThisTag);
            myRFIDReader.Close();
            LogMessage(ErrorType.RFID, "Closed");

        }
        #endregion

       #region PrivateMethod
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            if (combox != null)
            {
                CampSpot selectedCampSpot = combox.SelectedItem as CampSpot;
                if (selectedCampSpot != null)
                {
                    CampReserVation.Location foundLocation = databaseHelper.GetLocation(selectedCampSpot.LocationId);

                    lblLocationName.Text = foundLocation.LocationName;
                }
            }
        }
        private bool InputValidation()
        {
            return !String.IsNullOrEmpty(dtpStartDate.Text) &&
                   !String.IsNullOrEmpty(dtpEndDate.Text) &&
                   !String.IsNullOrEmpty(tbParticipantType.Text) &&
                   !String.IsNullOrEmpty(nmUpNrOfMember.Text) &&
                   !String.IsNullOrEmpty(cbxSelectedAmount.Text);
        }


        private void btnReservation_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
