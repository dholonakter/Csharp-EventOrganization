namespace ManagerApp
{
    partial class AnalyticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartIncomePerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIncomePerHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartIncomePerType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTicketsPerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartIncomeShop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTicketsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomeShop)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIncomePerDay
            // 
            chartArea6.Name = "ChartArea1";
            this.chartIncomePerDay.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartIncomePerDay.Legends.Add(legend6);
            this.chartIncomePerDay.Location = new System.Drawing.Point(12, 48);
            this.chartIncomePerDay.Name = "chartIncomePerDay";
            this.chartIncomePerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Income";
            this.chartIncomePerDay.Series.Add(series6);
            this.chartIncomePerDay.Size = new System.Drawing.Size(429, 263);
            this.chartIncomePerDay.TabIndex = 0;
            this.chartIncomePerDay.Text = "chart1";
            // 
            // chartIncomePerHour
            // 
            chartArea7.Name = "ChartArea1";
            this.chartIncomePerHour.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartIncomePerHour.Legends.Add(legend7);
            this.chartIncomePerHour.Location = new System.Drawing.Point(466, 48);
            this.chartIncomePerHour.Name = "chartIncomePerHour";
            this.chartIncomePerHour.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Income";
            this.chartIncomePerHour.Series.Add(series7);
            this.chartIncomePerHour.Size = new System.Drawing.Size(548, 263);
            this.chartIncomePerHour.TabIndex = 1;
            this.chartIncomePerHour.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick 23/05 or 24/05 for data";
            // 
            // chartIncomePerType
            // 
            chartArea8.Name = "ChartArea1";
            this.chartIncomePerType.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartIncomePerType.Legends.Add(legend8);
            this.chartIncomePerType.Location = new System.Drawing.Point(12, 329);
            this.chartIncomePerType.Name = "chartIncomePerType";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Income";
            this.chartIncomePerType.Series.Add(series8);
            this.chartIncomePerType.Size = new System.Drawing.Size(429, 263);
            this.chartIncomePerType.TabIndex = 4;
            this.chartIncomePerType.Text = "chart1";
            // 
            // chartTicketsPerDay
            // 
            chartArea9.Name = "ChartArea1";
            this.chartTicketsPerDay.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartTicketsPerDay.Legends.Add(legend9);
            this.chartTicketsPerDay.Location = new System.Drawing.Point(466, 329);
            this.chartTicketsPerDay.Name = "chartTicketsPerDay";
            this.chartTicketsPerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Income";
            this.chartTicketsPerDay.Series.Add(series9);
            this.chartTicketsPerDay.Size = new System.Drawing.Size(548, 263);
            this.chartTicketsPerDay.TabIndex = 5;
            this.chartTicketsPerDay.Text = "chart1";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(1316, 141);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(213, 24);
            this.comboBoxShop.TabIndex = 6;
            this.comboBoxShop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a shop to show their income per day";
            // 
            // chartIncomeShop
            // 
            chartArea10.Name = "ChartArea1";
            this.chartIncomeShop.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartIncomeShop.Legends.Add(legend10);
            this.chartIncomeShop.Location = new System.Drawing.Point(1031, 171);
            this.chartIncomeShop.Name = "chartIncomeShop";
            this.chartIncomeShop.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series10.ChartArea = "ChartArea1";
            series10.IsValueShownAsLabel = true;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Income";
            this.chartIncomeShop.Series.Add(series10);
            this.chartIncomeShop.Size = new System.Drawing.Size(498, 303);
            this.chartIncomeShop.TabIndex = 8;
            this.chartIncomeShop.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1228, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 3000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // AnalyticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartIncomeShop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.chartTicketsPerDay);
            this.Controls.Add(this.chartIncomePerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartIncomePerHour);
            this.Controls.Add(this.chartIncomePerDay);
            this.Name = "AnalyticForm";
            this.Text = "AnalyticForm";
            this.Load += new System.EventHandler(this.AnalyticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTicketsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomeShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerHour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTicketsPerDay;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomeShop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerUpdate;
    }
}