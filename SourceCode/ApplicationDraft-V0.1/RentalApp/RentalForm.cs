﻿using System;
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
using System.Globalization;

namespace RentalApp
{
    public partial class RentalForm : Form
    {
        Order o;
        DataHelper data;
        bool borrow;
        Shop selectedShop;
        Visitor v;
        RFID myRFIDReader;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        //STARTUP
        public RentalForm(Shop s)
        {
            InitializeComponent();
            selectedShop = s;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = borrowBtn.Height;
            sideHighlight.Top = borrowBtn.Top;
            borrowPanel.BringToFront();

            // switchy switch
            borrow = true;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = returnBtn.Height;
            sideHighlight.Top = returnBtn.Top;
            returnPanel.BringToFront();

            // switchy switch
            borrow = false;
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            // init values
            borrow = true;
            data = new DataHelper();
            myRFIDReader = new RFID();
            myRFIDReader.Tag += ScanVisitor;
            o = new Order(selectedShop);

            myRFIDReader.Open();

            // GUI
            labelShopName.Text = "Loan Stand " + selectedShop.ShopName;
            sideHighlight.Height = borrowBtn.Height;
            sideHighlight.Top = borrowBtn.Top;
            borrowPanel.BringToFront();
        }

        // RFID PROCESSING
        private void ScanVisitor(object sender, RFIDTagEventArgs e)
        {
            o = new Order(selectedShop);

            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                {
                    display.SetText(v.ToString(), labelVisitorB);
                }

                if (MessageBox.Show("Please start scanning your items", "Confirm", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    myRFIDReader.Tag -= ScanVisitor;
                    if (borrow)
                    {
                        myRFIDReader.Tag += ScanToBorrow;
                    }
                    else
                    {
                        myRFIDReader.Tag += ScanToReturn;
                    }
                }
            }
        }

        private void ScanToBorrow(object sender, RFIDTagEventArgs e)
        {
            LoanArticle a = data.FindLoanArticleByTag(e.Tag);

            try
            {
                if (o.ExistsArticle(a))
                {
                    MessageBox.Show("Items already added");
                }
                else
                {
                    o.AddArticle(a, 1); // borrowing 1 article
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText(o.GetDepositReceipt(), labelBorrowInfo);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Item not found");
            }
        }

        private void ScanToReturn(object sender, RFIDTagEventArgs e)
        {
            LoanArticle a = data.FindLoanArticleByTag(e.Tag);

            try
            {
                if (o.ExistsArticle(a))
                {
                    MessageBox.Show("Items already added");
                }
                else
                {
                    DateTime timeOfOrder = data.GetOrderDateOfArticle(a, v.IdNr.ToString());

                    int quantity = DateTime.Now.Subtract(timeOfOrder).Hours; // get number of hours borrowed

                    o.AddArticle(a, quantity); // add that as quantity

                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText(o.GetReturnReceipt(), labelReturnInfo);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Item not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reset
            myRFIDReader.Tag -= ScanToBorrow;
            myRFIDReader.Tag -= ScanToReturn;
            myRFIDReader.Tag += ScanVisitor;

            if (MessageBox.Show("Confirm payment?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (borrow)
                {
                    if (v.Credit < o.GetLoanDeposit())
                    {
                        MessageBox.Show("Visitor does not have enough credit.");
                    }
                    else
                    {
                        v.Credit -= o.GetLoanDeposit();
                        o.OrderDate = DateTime.Now;
                        o.VisitorNr = v.IdNr;

                        if (data.CreateNewLoanOrder(o) == 1 && data.AddLoanOrderLine(o) != -1 && data.UpdateSelectedVisitor(v) != -1)
                        {
                            labelBorrowInfo.Text = o.GetDepositReceipt();
                            labelVisitorB.Text = v.ToString();
                        }
                    }
                }
                else
                {
                    if (v.Credit < o.GetLoanFee())
                    {
                        MessageBox.Show("Visitor does not have enough credit.");
                    }
                    else
                    {
                        // return deposit take fees
                        v.Credit = v.Credit + o.GetLoanDeposit() - o.GetLoanFee();
                        o.OrderDate = DateTime.Now; // the date of the "return order" 

                        if (data.ProcessLoanReturn(o, v.IdNr.ToString()) != -1 && data.UpdateSelectedVisitor(v) != -1)
                        {
                            labelReturnInfo.Text = o.GetReturnReceipt();
                            labelVisitorR.Text = v.ToString();
                        }
                    }
                }
            }
            o = new Order(selectedShop);
        }

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }
    }
}
