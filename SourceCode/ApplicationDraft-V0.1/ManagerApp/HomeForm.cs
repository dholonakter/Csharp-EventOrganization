using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class HomeForm : Form
    {


        public HomeForm()
        {
            InitializeComponent();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visitorBtn_Click(object sender, EventArgs e)
        {

            VisitorForm visitor = new VisitorForm();
            visitor.Show();
            this.Hide();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {

            ShopForm shop= new ShopForm();
            shop.Show();
            this.Hide();

        }

        private void campBtn_Click(object sender, EventArgs e)
        {

            CampForm camp = new CampForm();
            camp.Show();
            this.Hide();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {

            StockForm inventory = new StockForm();
            inventory.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

        }

        private void analyticBtn_Click(object sender, EventArgs e)
        {
          
            AnalyticForm analytics = new AnalyticForm();
            analytics.Show();
            this.Hide();
        }
    }
}
