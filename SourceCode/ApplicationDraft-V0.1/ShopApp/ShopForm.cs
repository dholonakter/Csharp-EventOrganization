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

        public ShopForm()
        {
            InitializeComponent();
            selectedShop = new Shop(3, "Topicstorm", "Beersel");
            data = new DataHelper();
            o = new Order(selectedShop);
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

            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i]);
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = cartBtn.Height;
            sideHighlight.Top = cartBtn.Top;
          

            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i]);
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void foodRbtn_CheckedChanged(object sender, EventArgs e)
        {
            List<Article> article = data.GetFoodArticles(3);

            itemLbx.Items.Clear();
            foreach (Article a in article)
            {
                itemLbx.Items.Add(a);
            }
        }

        private void drinkRbtn_CheckedChanged(object sender, EventArgs e)
        {
            List<Article> article = data.GetDrinkArticles(3);

            itemLbx.Items.Clear();
            foreach (Article a in article)
            {
                itemLbx.Items.Add(a);
            }
        }

        private void addcartBtn_Click(object sender, EventArgs e)
        {
            o.AddArticle((Article)itemLbx.SelectedItem, Convert.ToInt32(quantitySelec.Value));
            subtotalLbl.Text = "Subtotal: " + Convert.ToString(o.GetSum());

            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i]);
            }
        }


        private void quantitySelec_ValueChanged(object sender, EventArgs e)
        {
            /*
            Article a = (Article)itemLbx.SelectedItem;
            if (!o.Articles.Contains(a))
            {
                o.Articles.Add(a);
                o.Quantity.Add(0);
            }*/
            o.RemoveArticle((Article)itemLbx.SelectedItem, o.Quantity[o.Articles.IndexOf((Article)itemLbx.SelectedItem)] - Convert.ToInt32(quantitySelec.Value));
            label4.Text = o.ToString();
        }

        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemLbx.SelectedItem != null)
            {
                Article a = (Article)itemLbx.SelectedItem;
                if (!o.Articles.Contains(a))
                {
                    o.Articles.Add(a);
                    o.Quantity.Add(0);
                }
                quantitySelec.Value = o.Quantity[o.Articles.IndexOf(a)];
            }
        }
    }
}
