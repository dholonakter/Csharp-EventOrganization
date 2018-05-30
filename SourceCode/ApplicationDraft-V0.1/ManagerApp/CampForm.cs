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
    public partial class CampForm : Form
    {
        DataHelper dh;
        BindingSource campTable;

        public CampForm()
        {
            InitializeComponent();

            dh = new DataHelper();
        }
        private void ShowAll()
        {
            // Display data onto gridview
            campTable = new BindingSource();
            campTable.DataSource = dh.LoadCamps();
            dataGridViewCamp.DataSource = campTable;
        }
        private void buttonAll_Click(object sender, EventArgs e)
        {

        }
    }
}
