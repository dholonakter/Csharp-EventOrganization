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
            this.logsClearBtn = new System.Windows.Forms.Button();
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
            this.totalLoanLbl = new System.Windows.Forms.Label();
            this.orderLoanInfoLbl = new System.Windows.Forms.Label();
            this.loanCustomerInfoLbl = new System.Windows.Forms.Label();
            this.loanInfoLbx = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.confirmLoanBtn = new System.Windows.Forms.Button();
            this.loanClearBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.loaningLbl = new System.Windows.Forms.Label();
            this.labelBorrowInfo = new System.Windows.Forms.Label();
            this.labelVisitorB = new System.Windows.Forms.Label();
            this.returnPanel = new System.Windows.Forms.Panel();
            this.orderReturnInfoLbl = new System.Windows.Forms.Label();
            this.returnDepositLbl = new System.Windows.Forms.Label();
            this.customerReturnInfoLbl = new System.Windows.Forms.Label();
            this.returnLbx = new System.Windows.Forms.ListBox();
            this.confirmReturnBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.depositLbl = new System.Windows.Forms.Label();
            this.returnLbl = new System.Windows.Forms.Label();
            this.labelVisitorR = new System.Windows.Forms.Label();
            this.labelReturnInfo = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 640);
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
            this.monitorBtn.Location = new System.Drawing.Point(11, 231);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 54);
            this.monitorBtn.TabIndex = 22;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
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
            this.borrowBtn.Location = new System.Drawing.Point(11, 89);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(155, 54);
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
            this.returnBtn.Location = new System.Drawing.Point(11, 157);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(155, 54);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Returning";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 10);
            this.panel2.TabIndex = 1;
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.logsClearBtn);
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
            this.startPanel.Location = new System.Drawing.Point(220, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1105, 687);
            this.startPanel.TabIndex = 10;
            // 
            // logsClearBtn
            // 
            this.logsClearBtn.Location = new System.Drawing.Point(669, 471);
            this.logsClearBtn.Name = "logsClearBtn";
            this.logsClearBtn.Size = new System.Drawing.Size(124, 69);
            this.logsClearBtn.TabIndex = 54;
            this.logsClearBtn.Text = "Clear All";
            this.logsClearBtn.UseVisualStyleBackColor = true;
            // 
            // currentBtn
            // 
            this.currentBtn.Location = new System.Drawing.Point(425, 471);
            this.currentBtn.Name = "currentBtn";
            this.currentBtn.Size = new System.Drawing.Size(124, 69);
            this.currentBtn.TabIndex = 55;
            this.currentBtn.Text = "Currently Loaning";
            this.currentBtn.UseVisualStyleBackColor = true;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(275, 471);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(124, 69);
            this.viewAllBtn.TabIndex = 56;
            this.viewAllBtn.Text = "View All Items";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Location = new System.Drawing.Point(135, 471);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(124, 69);
            this.viewLogsBtn.TabIndex = 57;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.Location = new System.Drawing.Point(135, 219);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(658, 238);
            this.logsInfoLbx.TabIndex = 53;
            // 
            // personNrRbtn
            // 
            this.personNrRbtn.AutoSize = true;
            this.personNrRbtn.Location = new System.Drawing.Point(324, 65);
            this.personNrRbtn.Name = "personNrRbtn";
            this.personNrRbtn.Size = new System.Drawing.Size(75, 17);
            this.personNrRbtn.TabIndex = 51;
            this.personNrRbtn.TabStop = true;
            this.personNrRbtn.Text = "Person_Nr";
            this.personNrRbtn.UseVisualStyleBackColor = true;
            // 
            // personNameRbtn
            // 
            this.personNameRbtn.AutoSize = true;
            this.personNameRbtn.Location = new System.Drawing.Point(226, 65);
            this.personNameRbtn.Name = "personNameRbtn";
            this.personNameRbtn.Size = new System.Drawing.Size(92, 17);
            this.personNameRbtn.TabIndex = 52;
            this.personNameRbtn.TabStop = true;
            this.personNameRbtn.Text = "Person_Name";
            this.personNameRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNrRbtn
            // 
            this.itemNrRbtn.AutoSize = true;
            this.itemNrRbtn.Location = new System.Drawing.Point(147, 65);
            this.itemNrRbtn.Name = "itemNrRbtn";
            this.itemNrRbtn.Size = new System.Drawing.Size(62, 17);
            this.itemNrRbtn.TabIndex = 51;
            this.itemNrRbtn.TabStop = true;
            this.itemNrRbtn.Text = "Item_Nr";
            this.itemNrRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNameRbtn
            // 
            this.itemNameRbtn.AutoSize = true;
            this.itemNameRbtn.Location = new System.Drawing.Point(52, 65);
            this.itemNameRbtn.Name = "itemNameRbtn";
            this.itemNameRbtn.Size = new System.Drawing.Size(79, 17);
            this.itemNameRbtn.TabIndex = 52;
            this.itemNameRbtn.TabStop = true;
            this.itemNameRbtn.Text = "Item_Name";
            this.itemNameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(38, 86);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(83, 23);
            this.searchLbl.TabIndex = 50;
            this.searchLbl.Text = "Search:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.DimGray;
            this.errorLbl.Location = new System.Drawing.Point(131, 115);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(162, 23);
            this.errorLbl.TabIndex = 48;
            this.errorLbl.Text = "(error message)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(38, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Rental Logs";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(135, 87);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(195, 20);
            this.textBoxSearch.TabIndex = 47;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(24, 54);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 22);
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
            this.buttonSearch.Location = new System.Drawing.Point(343, 87);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(31, 22);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // borrowPanel
            // 
            this.borrowPanel.Controls.Add(this.totalLoanLbl);
            this.borrowPanel.Controls.Add(this.orderLoanInfoLbl);
            this.borrowPanel.Controls.Add(this.loanCustomerInfoLbl);
            this.borrowPanel.Controls.Add(this.loanInfoLbx);
            this.borrowPanel.Controls.Add(this.removeBtn);
            this.borrowPanel.Controls.Add(this.confirmLoanBtn);
            this.borrowPanel.Controls.Add(this.loanClearBtn);
            this.borrowPanel.Controls.Add(this.totalLbl);
            this.borrowPanel.Controls.Add(this.loaningLbl);
            this.borrowPanel.Controls.Add(this.labelBorrowInfo);
            this.borrowPanel.Controls.Add(this.labelVisitorB);
            this.borrowPanel.Location = new System.Drawing.Point(223, 73);
            this.borrowPanel.Name = "borrowPanel";
            this.borrowPanel.Size = new System.Drawing.Size(997, 634);
            this.borrowPanel.TabIndex = 11;
            // 
            // totalLoanLbl
            // 
            this.totalLoanLbl.AutoSize = true;
            this.totalLoanLbl.Location = new System.Drawing.Point(379, 430);
            this.totalLoanLbl.Name = "totalLoanLbl";
            this.totalLoanLbl.Size = new System.Drawing.Size(24, 13);
            this.totalLoanLbl.TabIndex = 42;
            this.totalLoanLbl.Text = "info";
            // 
            // orderLoanInfoLbl
            // 
            this.orderLoanInfoLbl.AutoSize = true;
            this.orderLoanInfoLbl.Location = new System.Drawing.Point(379, 134);
            this.orderLoanInfoLbl.Name = "orderLoanInfoLbl";
            this.orderLoanInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.orderLoanInfoLbl.TabIndex = 42;
            this.orderLoanInfoLbl.Text = "info";
            // 
            // loanCustomerInfoLbl
            // 
            this.loanCustomerInfoLbl.AutoSize = true;
            this.loanCustomerInfoLbl.Location = new System.Drawing.Point(379, 57);
            this.loanCustomerInfoLbl.Name = "loanCustomerInfoLbl";
            this.loanCustomerInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.loanCustomerInfoLbl.TabIndex = 42;
            this.loanCustomerInfoLbl.Text = "info";
            // 
            // loanInfoLbx
            // 
            this.loanInfoLbx.FormattingEnabled = true;
            this.loanInfoLbx.Location = new System.Drawing.Point(58, 111);
            this.loanInfoLbx.Name = "loanInfoLbx";
            this.loanInfoLbx.Size = new System.Drawing.Size(269, 290);
            this.loanInfoLbx.TabIndex = 32;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(58, 406);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(124, 60);
            this.removeBtn.TabIndex = 31;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmLoanBtn
            // 
            this.confirmLoanBtn.Location = new System.Drawing.Point(602, 398);
            this.confirmLoanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmLoanBtn.Name = "confirmLoanBtn";
            this.confirmLoanBtn.Size = new System.Drawing.Size(124, 68);
            this.confirmLoanBtn.TabIndex = 31;
            this.confirmLoanBtn.Text = "Confirm";
            this.confirmLoanBtn.UseVisualStyleBackColor = true;
            this.confirmLoanBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loanClearBtn
            // 
            this.loanClearBtn.Location = new System.Drawing.Point(203, 406);
            this.loanClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loanClearBtn.Name = "loanClearBtn";
            this.loanClearBtn.Size = new System.Drawing.Size(124, 60);
            this.loanClearBtn.TabIndex = 31;
            this.loanClearBtn.Text = "Clear All";
            this.loanClearBtn.UseVisualStyleBackColor = true;
            this.loanClearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.DimGray;
            this.totalLbl.Location = new System.Drawing.Point(378, 406);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(68, 23);
            this.totalLbl.TabIndex = 30;
            this.totalLbl.Text = "Total:";
            // 
            // loaningLbl
            // 
            this.loaningLbl.AutoSize = true;
            this.loaningLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaningLbl.ForeColor = System.Drawing.Color.DimGray;
            this.loaningLbl.Location = new System.Drawing.Point(54, 30);
            this.loaningLbl.Name = "loaningLbl";
            this.loaningLbl.Size = new System.Drawing.Size(153, 23);
            this.loaningLbl.TabIndex = 30;
            this.loaningLbl.Text = "Loaning Items";
            // 
            // labelBorrowInfo
            // 
            this.labelBorrowInfo.AutoSize = true;
            this.labelBorrowInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrowInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelBorrowInfo.Location = new System.Drawing.Point(378, 111);
            this.labelBorrowInfo.Name = "labelBorrowInfo";
            this.labelBorrowInfo.Size = new System.Drawing.Size(73, 23);
            this.labelBorrowInfo.TabIndex = 27;
            this.labelBorrowInfo.Text = "Order:";
            // 
            // labelVisitorB
            // 
            this.labelVisitorB.AutoSize = true;
            this.labelVisitorB.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorB.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorB.Location = new System.Drawing.Point(378, 30);
            this.labelVisitorB.Name = "labelVisitorB";
            this.labelVisitorB.Size = new System.Drawing.Size(105, 23);
            this.labelVisitorB.TabIndex = 26;
            this.labelVisitorB.Text = "Customer";
            // 
            // returnPanel
            // 
            this.returnPanel.Controls.Add(this.orderReturnInfoLbl);
            this.returnPanel.Controls.Add(this.returnDepositLbl);
            this.returnPanel.Controls.Add(this.customerReturnInfoLbl);
            this.returnPanel.Controls.Add(this.returnLbx);
            this.returnPanel.Controls.Add(this.confirmReturnBtn);
            this.returnPanel.Controls.Add(this.button3);
            this.returnPanel.Controls.Add(this.depositLbl);
            this.returnPanel.Controls.Add(this.returnLbl);
            this.returnPanel.Controls.Add(this.labelVisitorR);
            this.returnPanel.Controls.Add(this.labelReturnInfo);
            this.returnPanel.Location = new System.Drawing.Point(223, 70);
            this.returnPanel.Name = "returnPanel";
            this.returnPanel.Size = new System.Drawing.Size(997, 634);
            this.returnPanel.TabIndex = 30;
            // 
            // orderReturnInfoLbl
            // 
            this.orderReturnInfoLbl.AutoSize = true;
            this.orderReturnInfoLbl.Location = new System.Drawing.Point(373, 137);
            this.orderReturnInfoLbl.Name = "orderReturnInfoLbl";
            this.orderReturnInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.orderReturnInfoLbl.TabIndex = 41;
            this.orderReturnInfoLbl.Text = "info";
            // 
            // returnDepositLbl
            // 
            this.returnDepositLbl.AutoSize = true;
            this.returnDepositLbl.Location = new System.Drawing.Point(358, 433);
            this.returnDepositLbl.Name = "returnDepositLbl";
            this.returnDepositLbl.Size = new System.Drawing.Size(24, 13);
            this.returnDepositLbl.TabIndex = 41;
            this.returnDepositLbl.Text = "info";
            // 
            // customerReturnInfoLbl
            // 
            this.customerReturnInfoLbl.AutoSize = true;
            this.customerReturnInfoLbl.Location = new System.Drawing.Point(373, 60);
            this.customerReturnInfoLbl.Name = "customerReturnInfoLbl";
            this.customerReturnInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.customerReturnInfoLbl.TabIndex = 41;
            this.customerReturnInfoLbl.Text = "info";
            // 
            // returnLbx
            // 
            this.returnLbx.FormattingEnabled = true;
            this.returnLbx.Location = new System.Drawing.Point(58, 114);
            this.returnLbx.Name = "returnLbx";
            this.returnLbx.Size = new System.Drawing.Size(269, 290);
            this.returnLbx.TabIndex = 40;
            // 
            // confirmReturnBtn
            // 
            this.confirmReturnBtn.Location = new System.Drawing.Point(602, 401);
            this.confirmReturnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmReturnBtn.Name = "confirmReturnBtn";
            this.confirmReturnBtn.Size = new System.Drawing.Size(124, 60);
            this.confirmReturnBtn.TabIndex = 38;
            this.confirmReturnBtn.Text = "Confirm";
            this.confirmReturnBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 409);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 60);
            this.button3.TabIndex = 39;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.ForeColor = System.Drawing.Color.DimGray;
            this.depositLbl.Location = new System.Drawing.Point(357, 409);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(85, 23);
            this.depositLbl.TabIndex = 35;
            this.depositLbl.Text = "Return:";
            // 
            // returnLbl
            // 
            this.returnLbl.AutoSize = true;
            this.returnLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLbl.ForeColor = System.Drawing.Color.DimGray;
            this.returnLbl.Location = new System.Drawing.Point(54, 33);
            this.returnLbl.Name = "returnLbl";
            this.returnLbl.Size = new System.Drawing.Size(172, 23);
            this.returnLbl.TabIndex = 36;
            this.returnLbl.Text = "Returning Items";
            // 
            // labelVisitorR
            // 
            this.labelVisitorR.AutoSize = true;
            this.labelVisitorR.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorR.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorR.Location = new System.Drawing.Point(369, 33);
            this.labelVisitorR.Name = "labelVisitorR";
            this.labelVisitorR.Size = new System.Drawing.Size(111, 23);
            this.labelVisitorR.TabIndex = 27;
            this.labelVisitorR.Text = "Customer:";
            // 
            // labelReturnInfo
            // 
            this.labelReturnInfo.AutoSize = true;
            this.labelReturnInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelReturnInfo.Location = new System.Drawing.Point(369, 114);
            this.labelReturnInfo.Name = "labelReturnInfo";
            this.labelReturnInfo.Size = new System.Drawing.Size(73, 23);
            this.labelReturnInfo.TabIndex = 26;
            this.labelReturnInfo.Text = "Order:";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(248, 31);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(162, 27);
            this.labelShopName.TabIndex = 31;
            this.labelShopName.Text = "SHOP NAME";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.borrowPanel);
            this.Controls.Add(this.returnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label labelVisitorR;
        private System.Windows.Forms.Label labelReturnInfo;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label loaningLbl;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button loanClearBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.ListBox loanInfoLbx;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label labelBorrowInfo;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button confirmLoanBtn;
        private System.Windows.Forms.ListBox returnLbx;
        private System.Windows.Forms.Button confirmReturnBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label depositLbl;
        private System.Windows.Forms.Label returnLbl;
        private System.Windows.Forms.Label totalLoanLbl;
        private System.Windows.Forms.Label orderLoanInfoLbl;
        private System.Windows.Forms.Label loanCustomerInfoLbl;
        private System.Windows.Forms.Label orderReturnInfoLbl;
        private System.Windows.Forms.Label returnDepositLbl;
        private System.Windows.Forms.Label customerReturnInfoLbl;
        private System.Windows.Forms.Button logsClearBtn;
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
    }
}

