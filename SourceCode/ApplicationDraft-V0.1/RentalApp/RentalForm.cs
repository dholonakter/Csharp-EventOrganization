using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalApp
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
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

        private void cartBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = cartBtn.Height;
            sideHighlight.Top = cartBtn.Top;
            cartPanel.BringToFront();
        }
    }
}
