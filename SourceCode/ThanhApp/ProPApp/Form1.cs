using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// RFID DLL
using Phidget22;
using Phidget22.Events;

namespace ProPApp
{
    public partial class Form1 : Form
    {
        RFID myRFIDReader;
        DataHelper data;
        Visitor selectedVisitor;
        Store selectedStore;

        public Form1()
        {
            InitializeComponent();
            data = new DataHelper();

            // for order time and date
            //MessageBox.Show(DateTime.Now.ToString("h:mm:ss tt dd/MM/yyyy"));

            // dummy data for testing:
            textBox2.Text = "31415926535";
            textBox1.Text = "1";

            // subscribing to rfid events
            try 
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += ShowAttached;
                myRFIDReader.Detach += ShowDetached;
                myRFIDReader.Tag += ProcessTag;
            }
            catch (PhidgetException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ShowAttached(object sender, EventArgs e)
        {
            MessageBox.Show("RFID reader attached: Serial nr. " + myRFIDReader.DeviceSerialNumber);
        }

        private void ShowDetached(object sender, EventArgs e)
        {
            MessageBox.Show("RFID reader detached: Serial nr. " + myRFIDReader.DeviceSerialNumber);
        }

        private void ProcessTag(object sender, RFIDTagEventArgs e)
        {
            /* CHECK IN CODE */
            if (selectedVisitor != null)
            {
                selectedVisitor.RFIDNr = e.Tag;
                if (data.UpdateSelectedVisitor(selectedVisitor) == 1)
                {
                    MessageBox.Show("Success!");
                }
            }
            else
            {
                MessageBox.Show("Selected visitor is null");
            }

            /* CHECK OUT CODE 
            selectedVisitor = data.FindVisitorByTag(e.Tag);
            if (selectedVisitor != null) // if visitor found w/ rfid
            {
                selectedVisitor.RFIDNr = null;
                data.UpdateSelectedVisitor(selectedVisitor);
            } */
        }

        /* --- DEALING WITH DATA BASE --- */
        private void DisplayCurrentSelectedVisitor()
        {
            label1.Text = selectedVisitor.ToString();
            if (selectedVisitor.Paid)
            {
                label3.Text = "OK - PAYMENT RECEIVED";
            }
            else
            {
                label3.Text = "NOT OK - PAYMENT NOT RECEIVED";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Visitor v in data.GetAllVisitors())
            {
                listBox1.Items.Add(v);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVisitor = (Visitor)listBox1.SelectedItem;
            DisplayCurrentSelectedVisitor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor v = data.FindVisitorByNr(textBox1.Text);
            listBox1.Items.Clear();
            if (v != null)
            {
                listBox1.Items.Add(v);
            }
            else
            {
                MessageBox.Show("Visitor not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (data.LinkRFID(selectedVisitor, textBox2.Text))
            {
                DisplayCurrentSelectedVisitor();
            }
            else
            {
                MessageBox.Show("RFID number already used");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visitor v = data.FindVisitorByTag(textBox3.Text);
            listBox1.Items.Clear();
            if (v != null)
            {
                listBox1.Items.Add(v);
            }
            else
            {
                MessageBox.Show("Visitor not found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedVisitor = data.FindVisitorByTag(textBox3.Text);
            if (selectedVisitor != null) // if visitor found w/ rfid
            {
                selectedVisitor.RFIDNr = "";
                selectedVisitor.CheckedIn = false;
                if (data.UpdateSelectedVisitor(selectedVisitor) == 1)
                {
                    DisplayCurrentSelectedVisitor();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedVisitor.Paid = true;
            data.UpdateSelectedVisitor(selectedVisitor);
            DisplayCurrentSelectedVisitor();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Store s in data.GetAllStores())
            {
                listBox2.Items.Add(s);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && listBox2.SelectedItem is Store)
            {
                selectedStore = (Store)listBox2.SelectedItem;
                label4.Text = selectedStore.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = "label5 restock list: \n";
            if (selectedStore != null)
            {
                listBox2.Items.Clear();
                foreach (StoreArticle a in data.GetArticlesOfStore(selectedStore))
                {
                    listBox2.Items.Add(a);
                    if (a.InStock < 10)
                    {
                        label5.Text += "- #" + a.ArticleNr + " - " + a.ArticleName;
                    }
                }
            }
        }
    }
}
