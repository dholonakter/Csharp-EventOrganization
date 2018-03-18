using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainBoss
{
    public partial class mainOverview : Form
    {
        public mainOverview()
        {
            InitializeComponent();

            // ---- GUI CODE PLEASE DO NOT TOUCH ---- //
            button6.Width = 243;
            button1.Width = 243;
            button4.Width = 243;
            button2.Width = 243;

            button4.Height = 148;
            button1.Height = 148;
            button6.Height = 148;
            button2.Height = 148;

            Point p = new Point(439, 46);
            button4.Location = p;

            p = new Point(439, 194);
            button6.Location = p;
            // ---- GUI CODE PLEASE DO NOT TOUCH ---- //
        }
        #region GUICODE
        private void ChangeColor(object o, Color c)
        {
            if (o is Button)
            {
                Button b = (Button)o;
                b.BackColor = c;
            }
            else if (o is Label)
            {
                Label l = (Label)o;
                l.BackColor = c;
            }
        }
        private void ResetButton(Button b)
        {
            b.Width = 243;
            b.Height = 148;
        }
        private void ShowButtonText(Button b, string t)
        {
            b.ImageAlign = ContentAlignment.MiddleCenter;
            b.Text = t;
            b.TextAlign = ContentAlignment.BottomCenter;
        }
        private void ResetButtonText(Button b)
        {
            b.ResetText();
            b.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "Event");
            button2.Width = 486;

            /* arduous measurement which if possible should be left alone */
            ResetButton(button4);
            ResetButton(button6);
            button4.Width = 122;
            button6.Width = 122;
            Point p = new Point(560, 194);
            button4.Location = p;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "Camp");
            button4.BringToFront();
            button4.Height = 296;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "Shop");
            button1.Location = button2.Location;
            button1.Height = 296;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BringToFront();
            ShowButtonText((Button)sender, "Staff");
            button6.Location = button1.Location;
            button6.Width = 486;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(89, 118, 185));
            ResetButtonText((Button)sender);
            button2.Width = 243;

            /* arduous measurement which if possible should be left alone */
            ResetButton(button4);
            ResetButton(button6);

            Point p = new Point(439, 46);
            button4.Location = p;

            p = new Point(439, 194);
            button6.Location = p;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(102, 187, 106));
            ResetButtonText((Button)sender);
            ResetButton(button4);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(79, 195, 247));
            ResetButtonText((Button)sender);
            ResetButton(button1);
            Point p = new Point(196, 194);
            button1.Location = p;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(255, 191, 96));
            ResetButtonText((Button)sender);
            ResetButton(button6);
            Point p = new Point(439, 194);
            button6.Location = p;
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void mainOverview_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            overviewEvent viewEvent = new overviewEvent();
            viewEvent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            overviewShop viewShop = new overviewShop();
            viewShop.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            overviewStaff viewStaff = new overviewStaff();
            viewStaff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            overviewCamp viewCamp = new overviewCamp();
            viewCamp.Show();
        }
    }
}
