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
    public partial class StockForm : Form
    {
        DataHelper dh;
        BindingSource dataTable;
        string sql;


        public StockForm()
        {
            InitializeComponent();
            dh = new DataHelper();
            timerUpdate.Start();
            sql = "select a.ArticleNr, s.ShopName, a.ShopNr, a.ArticleName, a.Price, a.Available, a.IsLoanable from article a, shop s where a.ShopNr = s.ShopNr ";
            Display(sql);
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            dataTable = new BindingSource();
            dataTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewInventory.DataSource = dataTable;
            dataGridViewInventory.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)dataTable.DataSource))
            {
                dataGridViewInventory.Refresh();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            timerUpdate.Start();
            sql = "select ArticleNr, ShopName, ShopNr, ArticleName, Price, Available, IsLoanable from article_shop where Available < " + Convert.ToInt32(numericUpDown1.Value);
            Display(sql);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            timerUpdate.Start();
            sql = "select ArticleNr, ShopName, ShopNr, ArticleName, Price, Available, IsLoanable from article_shop";
            Display(sql);
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
