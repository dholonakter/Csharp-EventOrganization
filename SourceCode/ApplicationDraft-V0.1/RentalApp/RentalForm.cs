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
using MySql;
using Phidget22;
using Phidget22.Events;


namespace RentalApp
{
    public partial class RentalForm : Form
    {
        Order o;
        DataHelper data;
        Shop selectedShop;
        Visitor v;
        RFID myRFIDReader;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        ///////////////////////////////////////
        // CROSS-THREAD DISPLAY
        ///////////////////////////////////////

        // Delegates for cross-thread processing
        delegate void LabelDelegate(string text, Label lb);
        delegate void ListboxDelegate(Object o, ListBox lb);
        delegate void VoidListboxDelegate(ListBox lb);

        // Clearing the given listbox
        private void ClearListbox(ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                VoidListboxDelegate d = new VoidListboxDelegate(ClearListbox);
                this.Invoke(d, new object[] { lb });
            }
            else
            {
                lb.Items.Clear();
            }
        }
        // Set text to label
        private void SetText(string text, Label lb)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (lb.InvokeRequired)
            {
                LabelDelegate d = new LabelDelegate(SetText);
                this.Invoke(d, new object[] { text, lb });
            }
            else
            {
                lb.Text = text;
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


        //STARTUP
        public RentalForm()
        {
            InitializeComponent();
            // init values
            data = new DataHelper();
            myRFIDReader = new RFID();

            myRFIDReader.Open();
            v = data.FindVisitorByTag("28007be1f9"); // to be deleted

            myRFIDReader.Tag += ScanVisitor;

            // to be deleted
            selectedShop = new Shop(7, "Eire", "Beersel");

            // GUI
            sideHighlight.Height = overviewBtn.Height;
            sideHighlight.Top = overviewBtn.Top;
            startPanel.BringToFront();
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = overviewBtn.Height;
            sideHighlight.Top = overviewBtn.Top;
            startPanel.BringToFront();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = productBtn.Height;
            sideHighlight.Top = productBtn.Top;
            productPanel.BringToFront();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
        }

        // RFID PROCESSING
        private void ScanVisitor(object sender, RFIDTagEventArgs e)
        {
            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                SetText(v.ToString(), labelVisitor);
                
                if (MessageBox.Show("Please start scanning your items", "Confirm", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    myRFIDReader.Tag -= ScanVisitor;
                    myRFIDReader.Tag += ScanItem;
                }
            }
        }
    
        private void ScanItem(object sender, RFIDTagEventArgs e)
        {
            LoanArticle a = data.FindLoanArticleByTag(e.Tag);
            if (a != null)
            {
                v.ArticlesBorrowed.Add(a);
                o.AddArticle(a, 1); // add to order
                SetText(o.ToString(), labelOrderInfo    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myRFIDReader.Tag -= ScanItem;
            myRFIDReader.Tag += ScanVisitor;

            if (MessageBox.Show("Confirm payment?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (v.Credit < o.GetSum())
                {
                    MessageBox.Show("Visitor does not have enough credit.");
                }
                else
                {
                    v.Credit -= o.GetSum();
                    o.OrderDate = DateTime.Now.ToString("yyyy-MM-dd");
                    o.OrderTime = DateTime.Now.ToString("hh:mm:ss");
                    o.VisitorNr = v.IdNr;
                    if (data.CreateNewOrder(o) == 1 && data.AddOrderLine(o) != -1)
                    {
                        SetText(o.ToString(), labelOrderInfo);
                        o = new Order(selectedShop);
                    }
                    data.UpdateSelectedVisitor(v);
                }
            }
            else
            {
                o = new Order(selectedShop);
            }

        }
    }
}
