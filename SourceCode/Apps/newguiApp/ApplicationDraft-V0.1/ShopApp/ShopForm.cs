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

        List<StoreArticle> allProducts;
        List<Button> buttons;
        List<Label> labels;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        // borrowed code
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public ShopForm(Shop s)
        {
            InitializeComponent();
            if (s != null)
            {
                selectedShop = s;
            }
            else
            {
                MessageBox.Show("You are logged in as admin");
            }
        }
        private int compareButtons(Button x, Button y)
        {
            int idOfX = Convert.ToInt32(x.Name.Substring(13));
            int idOfY = Convert.ToInt32(y.Name.Substring(13));
            return idOfX.CompareTo(idOfY);
        }

        private int compareLabels(Label x, Label y)
        {
            int idOfX = Convert.ToInt32(x.Name.Substring(12));
            int idOfY = Convert.ToInt32(y.Name.Substring(12));
            return idOfX.CompareTo(idOfY);
        }
        private void ShopForm_Load(object sender, EventArgs e)
        {
            // init values
            o = new Order(selectedShop);
            data = new DataHelper();
            myRFIDReader = new RFID();
            myRFIDReader.Tag += new RFIDTagEventHandler(Pay);
            myRFIDReader.Open();

            buttons = new List<Button>();
            labels = new List<Label>();
            allProducts = data.GetAllStoreArticles(selectedShop);

            labelShopName.Text = "Store " + selectedShop.ShopName;

            // GUI
            sideHighlight.Height = orderBtn.Height;
            sideHighlight.Top = orderBtn.Top;
            productPanel.BringToFront();

            // Store all the product buttons
            var buttonsInForms = GetAll(this, typeof(Button));
            foreach (Button b in buttonsInForms)
            {
                if (b.Name.StartsWith("productButton"))
                {
                    b.Text = ""; // clear text;
                    buttons.Add(b);
                }
            }

            buttons.Sort(new Comparison<Button>(compareButtons));

            // Store all the labels
            var labelsInForms = GetAll(this, typeof(Label));
            foreach (Label l in labelsInForms)
            {
                if (l.Name.StartsWith("productLabel"))
                {
                    l.Text = ""; // clear text
                    labels.Add(l);
                }
            }

            labels.Sort(new Comparison<Label>(compareLabels));

            DisplayProducts();
        }
        

        private void Pay(object sender, RFIDTagEventArgs e)
        {
            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                o.VisitorNr = v.IdNr;
                if (v.Credit < o.GetSum())
                {
                    MessageBox.Show("Visitor does not have enough credit.");
                }
                else
                {
                    v.Credit -= o.GetSum();
                    //ProcessOrder();
                    data.UpdateSelectedVisitor(v);
                }
            }
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = orderBtn.Height;
            sideHighlight.Top = orderBtn.Top;
            productPanel.BringToFront();
        }
        
        private void productBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = stockBtn.Height;
            sideHighlight.Top = stockBtn.Top;
            startPanel.BringToFront();
        }

        public void DisplayProducts()
        {
            
            int stopNumber = allProducts.Count > buttons.Count ? buttons.Count : allProducts.Count;
            

            for (int i = 0; i < stopNumber; i++)
            {
                // index backwards due to recursion method
                buttons[i].Image = System.Drawing.Image.FromFile("../../img/" + allProducts[i].ImgFile);
                labels[i].Text = allProducts[i].ArticleName;

                if (allProducts[i].Category == "Food")
                {
                    buttons[i].BackColor = Color.LightSalmon;
                }
                else if (allProducts[i].Category == "Drink")
                {
                    buttons[i].BackColor = Color.LightGreen;
                }
                else if (allProducts[i].Category == "Uncategorized")
                {
                    buttons[i].BackColor = Color.Silver;
                }
            }
        }


        /*
        public void DisplayProducts()
        {
            if (selectedShop != null)
            {
                CrossThreadDisplay display = new CrossThreadDisplay(this);
                if (foodRbtn.Checked)
                {
                    display.DisplayArticle(data.GetFoodArticles(selectedShop.ShopNr), itemLbx);
                }
                else
                {
                    display.DisplayArticle(data.GetDrinkArticles(selectedShop.ShopNr), itemLbx);
                }
                display.Dispose();
            }
        }
        */
        public void DisplayOrderItems()
        {
            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i] + "; Quantity: " + o.Quantity[i]);
            }
        }
        
        
        private void ProcessOrder()
        {
            if(MessageBox.Show("Confirm payment", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                o.OrderDate = DateTime.Now;

                if (data.CreateNewStoreOrder(o) == 1 && data.AddStoreOrderLine(o) != -1)
                {
                    o.OrderNr = data.GetRightOrderNr(o);
                    labelOrder.Text = "Order nr. " + o.OrderNr + " processed";
                }
            }
            o = new Order(selectedShop);
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
            labelOrderInfo.Text = o.ToString();
        }

        private void AddArticle(Button button)
        {
            int idOfButton = Convert.ToInt32(button.Name.Substring(13)); // gets the id from the control's name
            if (o != null)
            {
                o.AddArticle(allProducts[idOfButton - 1], 1);
                DisplayOrderItems();
            }
        }

        private void productButton1_Click(object sender, EventArgs e)
        {
            AddArticle((Button)sender);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (itemLbx.SelectedIndex != -1)
            {
                int selectedIndex = itemLbx.SelectedIndex;
                if (o.Quantity[selectedIndex] - 1 == 0)
                {
                    itemLbx.Items.Remove(itemLbx.SelectedItem);
                }
                o.SetQuantity(o.Articles[selectedIndex], o.Quantity[selectedIndex] - 1);
                DisplayOrderItems();
            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            if (itemLbx.SelectedIndex != -1)
            {
                int selectedIndex = itemLbx.SelectedIndex;
                o.SetQuantity(o.Articles[selectedIndex], o.Quantity[selectedIndex] + 1);
                DisplayOrderItems();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ProcessOrder();
        }
    }
}
