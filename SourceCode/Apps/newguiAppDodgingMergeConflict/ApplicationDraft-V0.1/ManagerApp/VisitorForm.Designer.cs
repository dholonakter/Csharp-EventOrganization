namespace ManagerApp
{
    partial class VisitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.LogsBtn = new System.Windows.Forms.Button();
            this.labelTotalVisitors = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            this.chartVisitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTotalSpent = new System.Windows.Forms.Label();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.tagRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(69, 116);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(1187, 65);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "    Visitors status";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1197, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 52);
            this.button7.TabIndex = 61;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(1264, 15);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 52);
            this.homeBtn.TabIndex = 62;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(80, 211);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(194, 28);
            this.searchLbl.TabIndex = 66;
            this.searchLbl.Text = "Search Visitor:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(291, 246);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(273, 22);
            this.textBoxSearch.TabIndex = 64;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(582, 241);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 27);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(84, 670);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(165, 49);
            this.viewAllBtn.TabIndex = 70;
            this.viewAllBtn.Text = "View All Visitors";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // LogsBtn
            // 
            this.LogsBtn.Location = new System.Drawing.Point(290, 670);
            this.LogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Size = new System.Drawing.Size(165, 49);
            this.LogsBtn.TabIndex = 71;
            this.LogsBtn.Text = "View all logs of specified visitor";
            this.LogsBtn.UseVisualStyleBackColor = true;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // labelTotalVisitors
            // 
            this.labelTotalVisitors.AutoSize = true;
            this.labelTotalVisitors.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalVisitors.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalVisitors.Location = new System.Drawing.Point(877, 549);
            this.labelTotalVisitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalVisitors.Name = "labelTotalVisitors";
            this.labelTotalVisitors.Size = new System.Drawing.Size(153, 23);
            this.labelTotalVisitors.TabIndex = 65;
            this.labelTotalVisitors.Text = "Total visitors:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(700, 670);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(165, 49);
            this.refreshBtn.TabIndex = 68;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewVisitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(84, 285);
            this.dataGridViewVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowTemplate.Height = 24;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(781, 366);
            this.dataGridViewVisitor.TabIndex = 72;
            // 
            // chartVisitor
            // 
            chartArea7.Name = "ChartArea1";
            this.chartVisitor.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartVisitor.Legends.Add(legend7);
            this.chartVisitor.Location = new System.Drawing.Point(881, 285);
            this.chartVisitor.Name = "chartVisitor";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Visitors";
            this.chartVisitor.Series.Add(series7);
            this.chartVisitor.Size = new System.Drawing.Size(421, 247);
            this.chartVisitor.TabIndex = 73;
            this.chartVisitor.Text = "chartVisitors";
            // 
            // labelTotalSpent
            // 
            this.labelTotalSpent.AutoSize = true;
            this.labelTotalSpent.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalSpent.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalSpent.Location = new System.Drawing.Point(876, 628);
            this.labelTotalSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSpent.Name = "labelTotalSpent";
            this.labelTotalSpent.Size = new System.Drawing.Size(132, 23);
            this.labelTotalSpent.TabIndex = 75;
            this.labelTotalSpent.Text = "Total spent:";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalBalance.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalBalance.Location = new System.Drawing.Point(876, 587);
            this.labelTotalBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(154, 23);
            this.labelTotalBalance.TabIndex = 76;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Location = new System.Drawing.Point(396, 214);
            this.tagRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(73, 21);
            this.tagRbtn.TabIndex = 79;
            this.tagRbtn.TabStop = true;
            this.tagRbtn.Text = "Tag Nr";
            this.tagRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Location = new System.Drawing.Point(291, 214);
            this.nameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(66, 21);
            this.nameRbtn.TabIndex = 78;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 732);
            this.Controls.Add(this.tagRbtn);
            this.Controls.Add(this.nameRbtn);
            this.Controls.Add(this.labelTotalBalance);
            this.Controls.Add(this.labelTotalSpent);
            this.Controls.Add(this.chartVisitor);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.LogsBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.labelTotalVisitors);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button LogsBtn;
        private System.Windows.Forms.Label labelTotalVisitors;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisitor;
        private System.Windows.Forms.Label labelTotalSpent;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.RadioButton tagRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
    }
}