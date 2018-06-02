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

        //STARTUP
        public RentalForm()
        {
            InitializeComponent();
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
            // init values
            o = new Order(selectedShop);
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

        // RFID PROCESSING
        private void ScanVisitor(object sender, RFIDTagEventArgs e)
        {
            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                {
                   display.SetText(v.ToString(), labelVisitor);
                }
                  
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

                using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                {
                    display.SetText(v.ToString(), labelVisitor);
                    display.SetText(o.ToString(), labelOrderInfo);
                }
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
                        using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                        {
                            display.SetText(o.ToString(), labelOrderInfo);
                        }
                        
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
