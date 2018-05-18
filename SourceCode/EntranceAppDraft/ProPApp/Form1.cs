using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPApp
{
    public partial class Form1 : Form
    {
        DataHelper data;
        Visitor selected;

        public Form1()
        {
            InitializeComponent();
            data = new DataHelper();
            // dummy data for testing:
            textBox2.Text = "31415926535";
            textBox1.Text = "1";
        }
        private void DisplayCurrentSelectedVisitor()
        {
            label1.Text = selected.ToString();
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
            selected = (Visitor)listBox1.SelectedItem;
            DisplayCurrentSelectedVisitor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor v = data.FindVisitor(textBox1.Text);
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
            if (data.LinkRFID(selected, textBox2.Text))
            {
                DisplayCurrentSelectedVisitor();
            }
            else
            {
                MessageBox.Show("RFID number already used");
            }
        }
    }
}
