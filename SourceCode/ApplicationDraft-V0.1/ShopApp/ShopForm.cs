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

namespace ShopApp
{
    public partial class ShopForm : Form
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
            List<Article> list = (List<Article>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                this.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (Article a in list)
                {
                    lb.Items.Add(a);
                }
            }
        }

        public ShopForm(Shop s)
        {
            InitializeComponent();

            // init values
            data = new DataHelper();
            myRFIDReader = new RFID();

            myRFIDReader.Tag += new RFIDTagEventHandler(Pay);
            myRFIDReader.Open();
            
            if (s != null)
            {
                selectedShop = s;
                labelAdminShop.Hide();
                comboBoxShop.Hide();
            }
            else
            {
                MessageBox.Show("You are logged in as admin");

                DataTable dt = data.DataTableFromSQL("SELECT ShopNr, ShopName FROM SHOP");

                comboBoxShop.ValueMember = "ShopNr";
                comboBoxShop.DisplayMember = "ShopName";
                comboBoxShop.DataSource = dt;
            }

            // GUI
            sideHighlight.Height = overviewBtn.Height;
            sideHighlight.Top = overviewBtn.Top;
            startPanel.BringToFront();
        }

        private void Pay(object sender, RFIDTagEventArgs e)
        {
            v = data.FindVisitorByTag(e.Tag);
            o.VisitorNr = v.IdNr;

            if (v.Credit < o.GetSum())
            {
                MessageBox.Show("Visitor does not have enough credit.");
            }
            else
            {
                v.Credit -= o.GetSum();
                ProcessOrder();
                data.UpdateSelectedVisitor(v);
            }
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
            
            if (selectedShop == null) // if admin is logged on 
            {
                foodRbtn.Enabled = false;
                drinkRbtn.Enabled = false;
                quantitySelec.Enabled = false;
            }
            else
            {
                DisplayProducts();
            }
        }

        public void DisplayProducts()
        {
            if (selectedShop != null)
            {
                if (foodRbtn.Checked)
                {
                    DisplayArticle(data.GetFoodArticles(selectedShop.ShopNr), itemLbx);
                }
                else
                {
                    DisplayArticle(data.GetDrinkArticles(selectedShop.ShopNr), itemLbx);
                }
            }
        }

        public void DisplayOrderItems()
        {
            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i]);
            }
        }


        private void ShopForm_Load(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
        }

        private void foodRbtn_CheckedChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void quantitySelec_ValueChanged(object sender, EventArgs e)
        {
            if (itemLbx.SelectedItem != null && o.Articles.Contains((Article)itemLbx.SelectedItem))
            {
                int amount = Convert.ToInt32(quantitySelec.Value);
                if (((Article)itemLbx.SelectedItem).Available - amount <= 0)
                {
                    o.SetQuantity((Article)itemLbx.SelectedItem, ((Article)itemLbx.SelectedItem).Available);
                }
                else
                {
                    o.SetQuantity((Article)itemLbx.SelectedItem, amount);
                }

                labelOrderInfo.Text = o.ToString();
            }
        }

        private void itemLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (((Article)itemLbx.SelectedItem).Available > 0)
                {
                    o.AddArticle((Article)itemLbx.SelectedItem, 1);
                    labelOrderInfo.Text = o.ToString();
                    UpdateNumericUpDown();
                }
                else
                {
                    MessageBox.Show("Item is out of stock");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an item before double clicking");
            }
        }

        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumericUpDown();
        }
        private void UpdateNumericUpDown()
        {
            if (itemLbx.SelectedItem != null)
            {
                if (o.Articles.Contains((Article)itemLbx.SelectedItem))
                {
                    quantitySelec.Value = o.Quantity[o.Articles.IndexOf((Article)itemLbx.SelectedItem)];
                }
            }
        }
        private void ProcessOrder()
        {
            o.OrderDate = DateTime.Now.ToString("yyyy-MM-dd");
            o.OrderTime = DateTime.Now.ToString("hh:mm:ss");

            if (data.CreateNewOrder(o) == 1 && data.AddOrderLine(o) != -1)
            {
                DisplayProducts();
                SetText(o.ToString(), labelOrderInfo);
                o = new Order(selectedShop);
            }
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }

        private void comboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShop = data.GetShopByNr(comboBoxShop.SelectedValue.ToString());
            DisplayProducts();
        }
    }
}
