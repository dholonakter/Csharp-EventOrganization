namespace CampingApp
{
    partial class CampingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.checkoutLogsBtn = new System.Windows.Forms.Button();
            this.checkinLogsBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.reservationRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.checkoutDetailsBtn = new System.Windows.Forms.Button();
            this.checkoutInfoLbx = new System.Windows.Forms.ListBox();
            this.checkoutMessageLbl = new System.Windows.Forms.Label();
            this.checkoutStatusLbl = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.labelEntrance = new System.Windows.Forms.Label();
            this.buttonOverride = new System.Windows.Forms.Button();
            this.buttonUserDetails = new System.Windows.Forms.Button();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.labelMessageIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirmPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.checkoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 788);
            this.panel1.TabIndex = 0;
            // 
            // checkinBtn
            // 
            this.checkinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.White;
            this.checkinBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBtn.Image")));
            this.checkinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBtn.Location = new System.Drawing.Point(12, 89);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(155, 74);
            this.checkinBtn.TabIndex = 12;
            this.checkinBtn.Text = " Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(12, 294);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 74);
            this.monitorBtn.TabIndex = 13;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(10, 74);
            this.sideHighlight.TabIndex = 14;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBtn.Image")));
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(12, 190);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(155, 74);
            this.checkoutBtn.TabIndex = 14;
            this.checkoutBtn.Text = "    Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 758);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.checkoutLogsBtn);
            this.searchPanel.Controls.Add(this.checkinLogsBtn);
            this.searchPanel.Controls.Add(this.viewLogsBtn);
            this.searchPanel.Controls.Add(this.logsInfoLbx);
            this.searchPanel.Controls.Add(this.reservationRbtn);
            this.searchPanel.Controls.Add(this.nameRbtn);
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Controls.Add(this.textBoxSearch);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Location = new System.Drawing.Point(205, 61);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1409, 903);
            this.searchPanel.TabIndex = 6;

            // 
            // checkoutLogsBtn
            // 
            this.checkoutLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkoutLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutLogsBtn.Location = new System.Drawing.Point(598, 559);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(189, 56);
            this.checkoutLogsBtn.TabIndex = 45;
            this.checkoutLogsBtn.Text = "Not fully present";
            this.checkoutLogsBtn.UseVisualStyleBackColor = false;
            this.checkoutLogsBtn.Click += new System.EventHandler(this.checkoutLogsBtn_Click);
            // 
            // checkinLogsBtn
            // 
            this.checkinLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.checkinLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkinLogsBtn.Location = new System.Drawing.Point(320, 559);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(189, 56);
            this.checkinLogsBtn.TabIndex = 46;
            this.checkinLogsBtn.Text = "Fully present";
            this.checkinLogsBtn.UseVisualStyleBackColor = false;
            this.checkinLogsBtn.Click += new System.EventHandler(this.checkinLogsBtn_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.BackColor = System.Drawing.Color.LightGray;
            this.viewLogsBtn.Enabled = false;
            this.viewLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogsBtn.ForeColor = System.Drawing.Color.White;
            this.viewLogsBtn.Location = new System.Drawing.Point(64, 559);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(189, 56);
            this.viewLogsBtn.TabIndex = 47;
            this.viewLogsBtn.Text = "View Campers";
            this.viewLogsBtn.UseVisualStyleBackColor = false;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 21;
            this.logsInfoLbx.Location = new System.Drawing.Point(64, 204);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(1026, 340);
            this.logsInfoLbx.TabIndex = 30;
            // 
            // reservationRbtn
            // 
            this.reservationRbtn.AutoSize = true;
            this.reservationRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationRbtn.Location = new System.Drawing.Point(218, 151);
            this.reservationRbtn.Name = "reservationRbtn";
            this.reservationRbtn.Size = new System.Drawing.Size(132, 25);
            this.reservationRbtn.TabIndex = 29;
            this.reservationRbtn.TabStop = true;
            this.reservationRbtn.Text = "Reservation Nr";
            this.reservationRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRbtn.Location = new System.Drawing.Point(142, 151);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(70, 25);
            this.nameRbtn.TabIndex = 29;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(33, 106);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 22);
            this.labelMonitor.TabIndex = 28;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(59, 151);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(76, 25);
            this.searchLbl.TabIndex = 14;
            this.searchLbl.Text = "Search:";
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
            this.buttonSearch.Location = new System.Drawing.Point(615, 147);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 33);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(365, 147);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 33);
            this.textBoxSearch.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(56, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 45);
            this.label9.TabIndex = 11;
            this.label9.Text = "LOGS";
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.labelExit);
            this.checkoutPanel.Controls.Add(this.checkoutDetailsBtn);
            this.checkoutPanel.Controls.Add(this.checkoutInfoLbx);
            this.checkoutPanel.Controls.Add(this.checkoutMessageLbl);
            this.checkoutPanel.Controls.Add(this.checkoutStatusLbl);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Location = new System.Drawing.Point(202, 64);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1349, 900);
            this.checkoutPanel.TabIndex = 7;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelExit.Location = new System.Drawing.Point(60, 40);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(198, 45);
            this.labelExit.TabIndex = 64;
            this.labelExit.Text = "CHECK OUT";
            // 
            // checkoutDetailsBtn
            // 
            this.checkoutDetailsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutDetailsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutDetailsBtn.Location = new System.Drawing.Point(68, 584);
            this.checkoutDetailsBtn.Name = "checkoutDetailsBtn";
            this.checkoutDetailsBtn.Size = new System.Drawing.Size(189, 52);
            this.checkoutDetailsBtn.TabIndex = 38;
            this.checkoutDetailsBtn.Text = "User Details";
            this.checkoutDetailsBtn.UseVisualStyleBackColor = false;
            this.checkoutDetailsBtn.Click += new System.EventHandler(this.checkoutDetailsBtn_Click);
            // 
            // checkoutInfoLbx
            // 
            this.checkoutInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutInfoLbx.FormattingEnabled = true;
            this.checkoutInfoLbx.ItemHeight = 21;
            this.checkoutInfoLbx.Location = new System.Drawing.Point(68, 233);
            this.checkoutInfoLbx.Name = "checkoutInfoLbx";
            this.checkoutInfoLbx.Size = new System.Drawing.Size(777, 319);
            this.checkoutInfoLbx.TabIndex = 37;
            // 
            // checkoutMessageLbl
            // 
            this.checkoutMessageLbl.AutoSize = true;
            this.checkoutMessageLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.checkoutMessageLbl.Location = new System.Drawing.Point(64, 180);
            this.checkoutMessageLbl.Name = "checkoutMessageLbl";
            this.checkoutMessageLbl.Size = new System.Drawing.Size(81, 21);
            this.checkoutMessageLbl.TabIndex = 36;
            this.checkoutMessageLbl.Text = "(message)";
            // 
            // checkoutStatusLbl
            // 
            this.checkoutStatusLbl.AutoSize = true;
            this.checkoutStatusLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutStatusLbl.Location = new System.Drawing.Point(150, 154);
            this.checkoutStatusLbl.Name = "checkoutStatusLbl";
            this.checkoutStatusLbl.Size = new System.Drawing.Size(95, 25);
            this.checkoutStatusLbl.TabIndex = 36;
            this.checkoutStatusLbl.Text = "(OK/NOK)";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(63, 154);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(81, 25);
            this.labelStatusOut.TabIndex = 34;
            this.labelStatusOut.Text = "STATUS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 10);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.labelEntrance);
            this.checkinPanel.Controls.Add(this.buttonConfirmPayment);
            this.checkinPanel.Controls.Add(this.buttonOverride);
            this.checkinPanel.Controls.Add(this.buttonUserDetails);
            this.checkinPanel.Controls.Add(this.listBoxCheckIn);
            this.checkinPanel.Controls.Add(this.labelMessageIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.label8);
            this.checkinPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkinPanel.Location = new System.Drawing.Point(199, 67);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1366, 797);
            this.checkinPanel.TabIndex = 8;
            // 
            // labelEntrance
            // 
            this.labelEntrance.AutoSize = true;
            this.labelEntrance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEntrance.Location = new System.Drawing.Point(61, 36);
            this.labelEntrance.Name = "labelEntrance";
            this.labelEntrance.Size = new System.Drawing.Size(167, 45);
            this.labelEntrance.TabIndex = 64;
            this.labelEntrance.Text = "CHECK IN";
            // 
            // buttonOverride
            // 
            this.buttonOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOverride.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonOverride.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonOverride.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonOverride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOverride.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverride.ForeColor = System.Drawing.Color.White;
            this.buttonOverride.Location = new System.Drawing.Point(284, 615);
            this.buttonOverride.Name = "buttonOverride";
            this.buttonOverride.Size = new System.Drawing.Size(189, 52);
            this.buttonOverride.TabIndex = 38;
            this.buttonOverride.Text = "Override";
            this.buttonOverride.UseVisualStyleBackColor = false;
            this.buttonOverride.Click += new System.EventHandler(this.buttonOverride_Click);
            // 
            // buttonUserDetails
            // 
            this.buttonUserDetails.BackColor = System.Drawing.Color.DimGray;
            this.buttonUserDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUserDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonUserDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserDetails.ForeColor = System.Drawing.Color.White;
            this.buttonUserDetails.Location = new System.Drawing.Point(69, 615);
            this.buttonUserDetails.Name = "buttonUserDetails";
            this.buttonUserDetails.Size = new System.Drawing.Size(189, 52);
            this.buttonUserDetails.TabIndex = 38;
            this.buttonUserDetails.Text = "User Details";
            this.buttonUserDetails.UseVisualStyleBackColor = false;
            this.buttonUserDetails.Click += new System.EventHandler(this.buttonUserDetails_Click);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 21;
            this.listBoxCheckIn.Location = new System.Drawing.Point(69, 230);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(936, 361);
            this.listBoxCheckIn.TabIndex = 37;
            // 
            // labelMessageIn
            // 
            this.labelMessageIn.AutoSize = true;
            this.labelMessageIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMessageIn.ForeColor = System.Drawing.Color.Red;
            this.labelMessageIn.Location = new System.Drawing.Point(65, 178);
            this.labelMessageIn.Name = "labelMessageIn";
            this.labelMessageIn.Size = new System.Drawing.Size(84, 20);
            this.labelMessageIn.TabIndex = 36;
            this.labelMessageIn.Text = "(message)";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(157, 148);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(95, 25);
            this.labelStatusIn.TabIndex = 36;
            this.labelStatusIn.Text = "(OK/NOK)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(64, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "STATUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(196, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 64;
            this.label2.Text = "Camping";
            // 
            // buttonConfirmPayment
            // 
            this.buttonConfirmPayment.BackColor = System.Drawing.Color.Green;
            this.buttonConfirmPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmPayment.Image")));
            this.buttonConfirmPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmPayment.Location = new System.Drawing.Point(878, 161);
            this.buttonConfirmPayment.Name = "buttonConfirmPayment";
            this.buttonConfirmPayment.Size = new System.Drawing.Size(127, 52);
            this.buttonConfirmPayment.TabIndex = 38;
            this.buttonConfirmPayment.Text = "Payment";
            this.buttonConfirmPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmPayment.UseVisualStyleBackColor = false;
            this.buttonConfirmPayment.Click += new System.EventHandler(this.buttonOverride_Click);
            // 
            // CampingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CampingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CampingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label checkoutStatusLbl;
        private System.Windows.Forms.Button checkoutDetailsBtn;
        private System.Windows.Forms.ListBox checkoutInfoLbx;
        private System.Windows.Forms.Label checkoutMessageLbl;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton reservationRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Label labelEntrance;
        private System.Windows.Forms.Button buttonOverride;
        private System.Windows.Forms.Button buttonUserDetails;
        private System.Windows.Forms.Label labelMessageIn;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmPayment;
    }
}

