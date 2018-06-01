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
    public partial class VisitorForm : Form
    {
        DataHelper dh;
        BindingSource visitorTable;
        string sql;

        public VisitorForm()
        {
            InitializeComponent();
            dh = new DataHelper();

            timerUpdate.Start();
            sql = "SELECT VisitorNr, FirstName, LastName, Phone, Email, UserPassword, RFIDNr, Credit, CheckedIn, SpotNr" + " FROM VISITOR";
            Display(sql);

            UpdateLabels();
        }
        private void Display(string sql)
        {
            // Display data onto gridview
            visitorTable = new BindingSource();
            visitorTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewVisitor.DataSource = visitorTable;
            dataGridViewVisitor.Refresh();
        }

        private void UpdateLabels()
        {
            int totalPresent = dh.CountRowTable("VISITOR");
            labelTotalVisitors.Text = "Total visitors: " + (totalPresent + dh.CountRowTable("DELETED_VISITOR")).ToString();
            labelTotalPresent.Text = "Total present: " + totalPresent.ToString();
            labelTotalBalance.Text = "Total balance: " + dh.GetTotalBalance();
            labelTotalSpent.Text = "Total spent: " + dh.GetTotalSpent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)visitorTable.DataSource))
            {
                dataGridViewVisitor.Refresh();
                UpdateLabels();
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            Display(sql);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
