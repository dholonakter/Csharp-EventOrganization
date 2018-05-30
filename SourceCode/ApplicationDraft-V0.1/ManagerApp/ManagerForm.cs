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

namespace ManagerApp
{
    public partial class ManagerForm : Form
    {
        /////////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Visitor visitor;
        DataHelper dh;
        BindingSource visitorTable;
        BindingSource activityTable;
        BindingSource problemTable;


        public ManagerForm()
        {
            InitializeComponent();
            sideHighlight.Height = eventBtn.Height;
            sideHighlight.Top = eventBtn.Top;
            //eventPanel.BringToFront();

            dh = new DataHelper();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = eventBtn.Height;
            sideHighlight.Top = eventBtn.Top;

            VisitorForm tf = new VisitorForm();
            tf.Show();
            tf.Focus();
            
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = shopBtn.Height;
            sideHighlight.Top = shopBtn.Top;
            //shopPanel.BringToFront();

            ShopForm sf = new ShopForm();
            sf.Show();
            sf.Focus();
        }

        private void campBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = campBtn.Height;
            sideHighlight.Top = campBtn.Top;
            //campPanel.BringToFront();

            CampForm cf = new CampForm();
            cf.Show();
            cf.Focus();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = rentBtn.Height;
            sideHighlight.Top = rentBtn.Top;
            rentalPanel.BringToFront();

            StockForm sf = new StockForm();
            sf.Show();
            sf.Focus();
        }

        private void analyticBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = analyticBtn.Height;
            sideHighlight.Top = analyticBtn.Top;
            analyticPanel.BringToFront();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = transBtn.Height;
            sideHighlight.Top = transBtn.Top;
            transPanel.BringToFront();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = staffBtn.Height;
            sideHighlight.Top = staffBtn.Top;
            staffPanel.BringToFront();
        }        
    }
}
