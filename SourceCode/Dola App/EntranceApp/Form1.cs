using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;



namespace EntranceApp
{
    public partial class Form1 : Form
    {
        private DataHelper dh;
        private RFID myRFIDReader;


        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            myRFIDReader = new RFID();
           // myRFIDReader.Attach += new AttachEventHandler(CheckIn);
           // myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
           // myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);

            listBox1.Items.Add("startup: so far so good.");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            List<Visitors> personlist;
            personlist = dh.GetAllVisitors();

            this.listBox1.Items.Clear();
            foreach (Visitors s in personlist)
            {
                listBox1.Items.Add(s.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            String name;
            int rfid;

            if (tbid.Text != "" && tbName.Text != "" && tbrfid.Text != "")
            {
                id = Convert.ToInt32(tbid.Text);
                name = tbName.Text;
                rfid = Convert.ToInt32(tbrfid.Text);
                int nrAdded = dh.AddVisitor(id, name, rfid);
                if (nrAdded > 0)
                {
                    MessageBox.Show("Succesfully added to the database");
                }
                else
                {
                    MessageBox.Show("Error while adding a visitor to the database");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
