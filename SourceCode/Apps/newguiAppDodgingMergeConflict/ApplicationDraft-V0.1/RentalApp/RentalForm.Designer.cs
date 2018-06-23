namespace RentalApp
{
    partial class RentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startPanel = new System.Windows.Forms.Panel();
            this.currentBtn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.personNrRbtn = new System.Windows.Forms.RadioButton();
            this.personNameRbtn = new System.Windows.Forms.RadioButton();
            this.itemNrRbtn = new System.Windows.Forms.RadioButton();
            this.itemNameRbtn = new System.Windows.Forms.RadioButton();
            this.searchLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.borrowPanel = new System.Windows.Forms.Panel();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelMessageB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.loanInfoLbx = new System.Windows.Forms.ListBox();
            this.labelBorrowInfo = new System.Windows.Forms.Label();
            this.loaningLbl = new System.Windows.Forms.Label();
            this.labelVisitorB = new System.Windows.Forms.Label();
            this.returnPanel = new System.Windows.Forms.Panel();
            this.labelInfoR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVisitorR = new System.Windows.Forms.Label();
            this.labelMessageR = new System.Windows.Forms.Label();
            this.returnLbx = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.borrowPanel.SuspendLayout();
            this.returnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.borrowBtn);
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 788);
            this.panel1.TabIndex = 0;
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(15, 284);
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 66);
            this.monitorBtn.TabIndex = 22;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 110);
            this.sideHighlight.Margin = new System.Windows.Forms.Padding(4);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(15, 66);
            this.sideHighlight.TabIndex = 14;
            // 
            // borrowBtn
            // 
            this.borrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.borrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowBtn.Image")));
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(15, 110);
            this.borrowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(207, 66);
            this.borrowBtn.TabIndex = 20;
            this.borrowBtn.Text = "Loaning";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(15, 193);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(207, 66);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Returning";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 12);
            this.panel2.TabIndex = 1;
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.currentBtn);
            this.startPanel.Controls.Add(this.viewAllBtn);
            this.startPanel.Controls.Add(this.viewLogsBtn);
            this.startPanel.Controls.Add(this.logsInfoLbx);
            this.startPanel.Controls.Add(this.personNrRbtn);
            this.startPanel.Controls.Add(this.personNameRbtn);
            this.startPanel.Controls.Add(this.itemNrRbtn);
            this.startPanel.Controls.Add(this.itemNameRbtn);
            this.startPanel.Controls.Add(this.searchLbl);
            this.startPanel.Controls.Add(this.errorLbl);
            this.startPanel.Controls.Add(this.label4);
            this.startPanel.Controls.Add(this.textBoxSearch);
            this.startPanel.Controls.Add(this.labelMonitor);
            this.startPanel.Controls.Add(this.buttonSearch);
            this.startPanel.Location = new System.Drawing.Point(293, 90);
            this.startPanel.Margin = new System.Windows.Forms.Padding(4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1473, 846);
            this.startPanel.TabIndex = 10;
            // 
            // currentBtn
            // 
            this.currentBtn.Location = new System.Drawing.Point(443, 496);
            this.currentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.currentBtn.Name = "currentBtn";
            this.currentBtn.Size = new System.Drawing.Size(165, 85);
            this.currentBtn.TabIndex = 55;
            this.currentBtn.Text = "Currently Loaning";
            this.currentBtn.UseVisualStyleBackColor = true;
            this.currentBtn.Click += new System.EventHandler(this.currentBtn_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(243, 496);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(165, 85);
            this.viewAllBtn.TabIndex = 56;
            this.viewAllBtn.Text = "View All Items";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Location = new System.Drawing.Point(56, 496);
            this.viewLogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(165, 85);
            this.viewLogsBtn.TabIndex = 57;
            this.viewLogsBtn.Text = "View Item\'s History";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 16;
            this.logsInfoLbx.Location = new System.Drawing.Point(56, 186);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(876, 292);
            this.logsInfoLbx.TabIndex = 53;
            // 
            // personNrRbtn
            // 
            this.personNrRbtn.AutoSize = true;
            this.personNrRbtn.Location = new System.Drawing.Point(432, 80);
            this.personNrRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.personNrRbtn.Name = "personNrRbtn";
            this.personNrRbtn.Size = new System.Drawing.Size(97, 21);
            this.personNrRbtn.TabIndex = 51;
            this.personNrRbtn.TabStop = true;
            this.personNrRbtn.Text = "Person_Nr";
            this.personNrRbtn.UseVisualStyleBackColor = true;
            // 
            // personNameRbtn
            // 
            this.personNameRbtn.AutoSize = true;
            this.personNameRbtn.Location = new System.Drawing.Point(301, 80);
            this.personNameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.personNameRbtn.Name = "personNameRbtn";
            this.personNameRbtn.Size = new System.Drawing.Size(119, 21);
            this.personNameRbtn.TabIndex = 52;
            this.personNameRbtn.TabStop = true;
            this.personNameRbtn.Text = "Person_Name";
            this.personNameRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNrRbtn
            // 
            this.itemNrRbtn.AutoSize = true;
            this.itemNrRbtn.Location = new System.Drawing.Point(196, 80);
            this.itemNrRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.itemNrRbtn.Name = "itemNrRbtn";
            this.itemNrRbtn.Size = new System.Drawing.Size(84, 21);
            this.itemNrRbtn.TabIndex = 51;
            this.itemNrRbtn.TabStop = true;
            this.itemNrRbtn.Text = "Item\'s Nr";
            this.itemNrRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNameRbtn
            // 
            this.itemNameRbtn.AutoSize = true;
            this.itemNameRbtn.Location = new System.Drawing.Point(69, 80);
            this.itemNameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameRbtn.Name = "itemNameRbtn";
            this.itemNameRbtn.Size = new System.Drawing.Size(106, 21);
            this.itemNameRbtn.TabIndex = 52;
            this.itemNameRbtn.TabStop = true;
            this.itemNameRbtn.Text = "Item\'s Name";
            this.itemNameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(51, 106);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(103, 28);
            this.searchLbl.TabIndex = 50;
            this.searchLbl.Text = "Search:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.errorLbl.Location = new System.Drawing.Point(175, 142);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(200, 28);
            this.errorLbl.TabIndex = 48;
            this.errorLbl.Text = "(error message)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(51, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 49;
            this.label4.Text = "Rental Logs";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(180, 107);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(259, 22);
            this.textBoxSearch.TabIndex = 47;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(32, 66);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 46;
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
            this.buttonSearch.Location = new System.Drawing.Point(457, 107);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 27);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // borrowPanel
            // 
            this.borrowPanel.Controls.Add(this.returnDatePicker);
            this.borrowPanel.Controls.Add(this.labelMessageB);
            this.borrowPanel.Controls.Add(this.label1);
            this.borrowPanel.Controls.Add(this.buttonConfirm);
            this.borrowPanel.Controls.Add(this.buttonRemove);
            this.borrowPanel.Controls.Add(this.loanInfoLbx);
            this.borrowPanel.Controls.Add(this.labelBorrowInfo);
            this.borrowPanel.Controls.Add(this.loaningLbl);
            this.borrowPanel.Controls.Add(this.labelVisitorB);
            this.borrowPanel.Location = new System.Drawing.Point(297, 90);
            this.borrowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.borrowPanel.Name = "borrowPanel";
            this.borrowPanel.Size = new System.Drawing.Size(1329, 780);
            this.borrowPanel.TabIndex = 11;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Location = new System.Drawing.Point(320, 159);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(244, 22);
            this.returnDatePicker.TabIndex = 52;
            this.returnDatePicker.ValueChanged += new System.EventHandler(this.returnDatePicker_ValueChanged);
            // 
            // labelMessageB
            // 
            this.labelMessageB.AutoSize = true;
            this.labelMessageB.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessageB.ForeColor = System.Drawing.Color.DimGray;
            this.labelMessageB.Location = new System.Drawing.Point(81, 194);
            this.labelMessageB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessageB.Name = "labelMessageB";
            this.labelMessageB.Size = new System.Drawing.Size(85, 21);
            this.labelMessageB.TabIndex = 51;
            this.labelMessageB.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(81, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Pick return date:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.DimGray;
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(337, 655);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(227, 62);
            this.buttonConfirm.TabIndex = 47;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.DimGray;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(85, 657);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(222, 61);
            this.buttonRemove.TabIndex = 46;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // loanInfoLbx
            // 
            this.loanInfoLbx.FormattingEnabled = true;
            this.loanInfoLbx.ItemHeight = 16;
            this.loanInfoLbx.Location = new System.Drawing.Point(85, 232);
            this.loanInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.loanInfoLbx.Name = "loanInfoLbx";
            this.loanInfoLbx.Size = new System.Drawing.Size(479, 404);
            this.loanInfoLbx.TabIndex = 32;
            // 
            // labelBorrowInfo
            // 
            this.labelBorrowInfo.AutoSize = true;
            this.labelBorrowInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelBorrowInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelBorrowInfo.Location = new System.Drawing.Point(80, 45);
            this.labelBorrowInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrowInfo.Name = "labelBorrowInfo";
            this.labelBorrowInfo.Size = new System.Drawing.Size(157, 28);
            this.labelBorrowInfo.TabIndex = 30;
            this.labelBorrowInfo.Text = "Scan visitor";
            // 
            // loaningLbl
            // 
            this.loaningLbl.AutoSize = true;
            this.loaningLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaningLbl.ForeColor = System.Drawing.Color.DimGray;
            this.loaningLbl.Location = new System.Drawing.Point(80, 117);
            this.loaningLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loaningLbl.Name = "loaningLbl";
            this.loaningLbl.Size = new System.Drawing.Size(146, 28);
            this.loaningLbl.TabIndex = 30;
            this.loaningLbl.Text = "Scan Items";
            // 
            // labelVisitorB
            // 
            this.labelVisitorB.AutoSize = true;
            this.labelVisitorB.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelVisitorB.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorB.Location = new System.Drawing.Point(81, 85);
            this.labelVisitorB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisitorB.Name = "labelVisitorB";
            this.labelVisitorB.Size = new System.Drawing.Size(108, 21);
            this.labelVisitorB.TabIndex = 26;
            this.labelVisitorB.Text = "visitor info";
            // 
            // returnPanel
            // 
            this.returnPanel.Controls.Add(this.labelInfoR);
            this.returnPanel.Controls.Add(this.label2);
            this.returnPanel.Controls.Add(this.labelVisitorR);
            this.returnPanel.Controls.Add(this.labelMessageR);
            this.returnPanel.Controls.Add(this.returnLbx);
            this.returnPanel.Controls.Add(this.label6);
            this.returnPanel.Location = new System.Drawing.Point(297, 86);
            this.returnPanel.Margin = new System.Windows.Forms.Padding(4);
            this.returnPanel.Name = "returnPanel";
            this.returnPanel.Size = new System.Drawing.Size(1329, 780);
            this.returnPanel.TabIndex = 30;
            // 
            // labelInfoR
            // 
            this.labelInfoR.AutoSize = true;
            this.labelInfoR.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelInfoR.ForeColor = System.Drawing.Color.DimGray;
            this.labelInfoR.Location = new System.Drawing.Point(543, 249);
            this.labelInfoR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoR.Name = "labelInfoR";
            this.labelInfoR.Size = new System.Drawing.Size(46, 21);
            this.labelInfoR.TabIndex = 63;
            this.labelInfoR.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "Scan visitor";
            // 
            // labelVisitorR
            // 
            this.labelVisitorR.AutoSize = true;
            this.labelVisitorR.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelVisitorR.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorR.Location = new System.Drawing.Point(36, 89);
            this.labelVisitorR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisitorR.Name = "labelVisitorR";
            this.labelVisitorR.Size = new System.Drawing.Size(108, 21);
            this.labelVisitorR.TabIndex = 61;
            this.labelVisitorR.Text = "visitor info";
            // 
            // labelMessageR
            // 
            this.labelMessageR.AutoSize = true;
            this.labelMessageR.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessageR.ForeColor = System.Drawing.Color.DimGray;
            this.labelMessageR.Location = new System.Drawing.Point(36, 221);
            this.labelMessageR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessageR.Name = "labelMessageR";
            this.labelMessageR.Size = new System.Drawing.Size(85, 21);
            this.labelMessageR.TabIndex = 60;
            this.labelMessageR.Text = "Message";
            // 
            // returnLbx
            // 
            this.returnLbx.FormattingEnabled = true;
            this.returnLbx.ItemHeight = 16;
            this.returnLbx.Location = new System.Drawing.Point(40, 249);
            this.returnLbx.Margin = new System.Windows.Forms.Padding(4);
            this.returnLbx.Name = "returnLbx";
            this.returnLbx.Size = new System.Drawing.Size(479, 404);
            this.returnLbx.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(35, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "Scan Items";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(331, 38);
            this.labelShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(197, 33);
            this.labelShopName.TabIndex = 31;
            this.labelShopName.Text = "SHOP NAME";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.borrowPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.returnPanel);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalForm_FormClosed);
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.borrowPanel.ResumeLayout(false);
            this.borrowPanel.PerformLayout();
            this.returnPanel.ResumeLayout(false);
            this.returnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel borrowPanel;
        private System.Windows.Forms.Label labelVisitorB;
        private System.Windows.Forms.Panel returnPanel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label loaningLbl;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.ListBox loanInfoLbx;
        private System.Windows.Forms.Label labelBorrowInfo;
        private System.Windows.Forms.Button currentBtn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton personNrRbtn;
        private System.Windows.Forms.RadioButton personNameRbtn;
        private System.Windows.Forms.RadioButton itemNrRbtn;
        private System.Windows.Forms.RadioButton itemNameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMessageB;
        private System.Windows.Forms.Label labelMessageR;
        private System.Windows.Forms.ListBox returnLbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVisitorR;
        private System.Windows.Forms.Label labelInfoR;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
    }
}

