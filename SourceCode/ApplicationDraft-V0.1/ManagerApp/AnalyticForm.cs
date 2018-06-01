using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManagerApp
{
    public partial class AnalyticForm : Form
    {
        DataHelper dh;

        public AnalyticForm()
        {
            InitializeComponent();
        }

        private void AnalyticForm_Load(object sender, EventArgs e)
        {
            dh = new DataHelper();
            fillChart();
            timerUpdate.Start();
        }

        private void FillComboBoxShop()
        {
            DataTable dt = dh.DataTableFromSQL("SELECT ShopNr, ShopName FROM SHOP");

            comboBoxShop.ValueMember = "ShopNr";
            comboBoxShop.DisplayMember = "ShopName";
            comboBoxShop.DataSource = dt;
        }

        private void fillChart()
        {
            // income per day
            chartIncomePerDay.Titles.Clear();
            chartIncomePerDay.DataSource = dh.GetDataset("select DATE_FORMAT(all_order.OrderDate,'%d/%m') 'OrderDate' , sum(Subtotal) 'Revenue' from all_order group by all_order.OrderDate ");
            //set the member of the chart data source used to data bind to the X-values of the series  
            chartIncomePerDay.Series["Income"].XValueMember = "OrderDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chartIncomePerDay.Series["Income"].YValueMembers = "Revenue";
            chartIncomePerDay.Titles.Add("Total earned per day");

            // income by type
            chartIncomePerType.Titles.Clear();
            DataSet ds = dh.GetDataset("select (select sum(Subtotal) from all_order where IsLoanable = 1) 'Loan', (select sum(Subtotal) from all_order where IsLoanable = 0) 'Store' from dual ");
            chartIncomePerType.Series["Income"].Points.AddXY("Loan", ds.Tables[0].Rows[0]["Loan"].ToString());
            chartIncomePerType.Series["Income"].Points.AddXY("Store", ds.Tables[0].Rows[0]["Store"].ToString());
            chartIncomePerType.Titles.Add("Total earned by shop type");

            // nr of tickets per day
            chartTicketsPerDay.Titles.Clear();
            chartTicketsPerDay.DataSource = dh.GetDataset("select DATE_FORMAT(ticket.TicketDate,'%d/%m') 'TicketDate', COUNT(*) 'NumberSold' from ticket group by TicketDate");
            //set the member of the chart data source used to data bind to the X-values of the series  
            chartTicketsPerDay.Series["Income"].XValueMember = "TicketDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chartTicketsPerDay.Series["Income"].YValueMembers = "NumberSold";
            chartTicketsPerDay.Titles.Add("Total of tickets sold per day");

        }
        private void FillIncomePerHour()
        {
            chartIncomePerHour.Titles.Clear(); // clearing titles
            chartIncomePerHour.DataSource = dh.GetDataset("select all_order.OrderDate, HOUR(all_order.OrderTime) 'Hour' , sum(Subtotal) 'Revenue'" +
                "from all_order where all_order.OrderDate = '" + (dateTimePicker1.Value.ToString("yyyy-MM-dd")) + "' " +
            "group by HOUR(all_order.OrderTime) ");

            if (((DataSet)chartIncomePerHour.DataSource).Tables[0].Rows.Count != 0)
            {
                chartIncomePerHour.Series["Income"].XValueMember = "Revenue";
                chartIncomePerHour.Series["Income"].YValueMembers = "Hour";
                chartIncomePerHour.Titles.Add("Total earned per hour of " + (dateTimePicker1.Value.ToString("dd/MM")));
            }
            else
            {
                chartIncomePerHour.Titles.Add("No data");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillIncomePerHour();
        }

        private void FillIncomeShop()
        {
            chartIncomeShop.Titles.Clear();
            chartIncomeShop.DataSource = dh.GetDataset("select DATE_FORMAT(all_order.OrderDate,'%d/%m') 'OrderDate', sum(Subtotal) 'Revenue' from all_order " +
                "where all_order.ShopNr = " + comboBoxShop.SelectedValue.ToString() + " group by OrderDate ");
            if (((DataSet)chartIncomeShop.DataSource).Tables[0].Rows.Count != 0)
            {
                chartIncomeShop.Series["Income"].XValueMember = "OrderDate";
                chartIncomeShop.Series["Income"].YValueMembers = "Revenue";
                chartIncomeShop.Titles.Add("Total earned per day of " + comboBoxShop.SelectedText);
            }
            else
            {
                chartIncomeShop.Titles.Add("No data");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillIncomeShop();
        }

        private void ClearChart(Chart c)
        {
            foreach (var series in c.Series)
            {
                series.Points.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearChart(chartIncomePerHour);
            ClearChart(chartIncomePerDay);
            ClearChart(chartIncomePerType);
            ClearChart(chartIncomeShop);
            ClearChart(chartTicketsPerDay);

            FillComboBoxShop();
            FillIncomePerHour();
            FillIncomeShop();
            fillChart();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            ClearChart(chartIncomePerHour);
            ClearChart(chartIncomePerDay);
            ClearChart(chartIncomePerType);
            ClearChart(chartIncomeShop);
            ClearChart(chartTicketsPerDay);

            FillComboBoxShop();
            FillIncomePerHour();
            FillIncomeShop();
            fillChart();
        }

        private void AnalyticForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Dispose();
            home.Show();
        }
    }
}
