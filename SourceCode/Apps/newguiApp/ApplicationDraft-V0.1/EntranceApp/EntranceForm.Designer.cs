namespace EntranceApp
{
    partial class EntranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStartWC = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.labelVisitor = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.webCamTimer = new System.Windows.Forms.Timer(this.components);
            this.checkinOverrideBtn = new System.Windows.Forms.Button();
            this.checkinClearBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkinHistoryBtn = new System.Windows.Forms.Button();
            this.checkinInfoLbx = new System.Windows.Forms.ListBox();
            this.checkinLbl = new System.Windows.Forms.Label();
            this.checkinMessageLbl = new System.Windows.Forms.Label();
            this.checkinStatusLbl = new System.Windows.Forms.Label();
            this.checkoutOverrideBtn = new System.Windows.Forms.Button();
            this.checkoutClearBtn = new System.Windows.Forms.Button();
            this.checkoutDetailsBtn = new System.Windows.Forms.Button();
            this.checkoutHistoryBtn = new System.Windows.Forms.Button();
            this.checkoutInfoLbx = new System.Windows.Forms.ListBox();
            this.campingCheckoutLbl = new System.Windows.Forms.Label();
            this.checkoutMessageLbl = new System.Windows.Forms.Label();
            this.checkoutStatusLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.campsiteLbl = new System.Windows.Forms.Label();
            this.rentalsLbl = new System.Windows.Forms.Label();
            this.campsiteStatusLbl = new System.Windows.Forms.Label();
            this.rentalStatusLbl = new System.Windows.Forms.Label();
            this.logsClearBtn = new System.Windows.Forms.Button();
            this.checkoutLogsBtn = new System.Windows.Forms.Button();
            this.checkinLogsBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.reservationRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.searchLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 768);
            this.panel1.TabIndex = 0;
            // 
            // checkinBtn
            // 
            this.checkinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.White;
            this.checkinBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBtn.Image")));
            this.checkinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBtn.Location = new System.Drawing.Point(11, 89);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(155, 54);
            this.checkinBtn.TabIndex = 9;
            this.checkinBtn.Text = "Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
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
            this.monitorBtn.Location = new System.Drawing.Point(11, 251);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 54);
            this.monitorBtn.TabIndex = 10;
            this.monitorBtn.Text = "    Monitoring";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBtn.Image")));
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(11, 170);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(155, 54);
            this.checkoutBtn.TabIndex = 11;
            this.checkoutBtn.Text = "   Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 10);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.checkinOverrideBtn);
            this.checkinPanel.Controls.Add(this.checkinClearBtn);
            this.checkinPanel.Controls.Add(this.button3);
            this.checkinPanel.Controls.Add(this.checkinHistoryBtn);
            this.checkinPanel.Controls.Add(this.checkinInfoLbx);
            this.checkinPanel.Controls.Add(this.checkinLbl);
            this.checkinPanel.Controls.Add(this.checkinMessageLbl);
            this.checkinPanel.Controls.Add(this.checkinStatusLbl);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.buttonStartWC);
            this.checkinPanel.Controls.Add(this.pictureBoxSource);
            this.checkinPanel.Location = new System.Drawing.Point(176, 16);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1105, 687);
            this.checkinPanel.TabIndex = 3;
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.ForeColor = System.Drawing.Color.DimGray;
            this.lbCheckIn.Location = new System.Drawing.Point(177, 175);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(115, 23);
            this.lbCheckIn.TabIndex = 37;
            this.lbCheckIn.Text = "Ticket info";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(447, 187);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(95, 23);
            this.labelStatusIn.TabIndex = 20;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(31, 154);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 124);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStartWC
            // 
            this.buttonStartWC.Location = new System.Drawing.Point(860, 400);
            this.buttonStartWC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartWC.Name = "buttonStartWC";
            this.buttonStartWC.Size = new System.Drawing.Size(154, 81);
            this.buttonStartWC.TabIndex = 3;
            this.buttonStartWC.Text = "Start webcam";
            this.buttonStartWC.UseVisualStyleBackColor = true;
            this.buttonStartWC.Click += new System.EventHandler(this.buttonStartWC_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(860, 184);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(213, 202);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.checkoutOverrideBtn);
            this.checkoutPanel.Controls.Add(this.checkoutClearBtn);
            this.checkoutPanel.Controls.Add(this.checkoutDetailsBtn);
            this.checkoutPanel.Controls.Add(this.checkoutHistoryBtn);
            this.checkoutPanel.Controls.Add(this.checkoutInfoLbx);
            this.checkoutPanel.Controls.Add(this.campingCheckoutLbl);
            this.checkoutPanel.Controls.Add(this.rentalsLbl);
            this.checkoutPanel.Controls.Add(this.campsiteLbl);
            this.checkoutPanel.Controls.Add(this.checkoutMessageLbl);
            this.checkoutPanel.Controls.Add(this.rentalStatusLbl);
            this.checkoutPanel.Controls.Add(this.campsiteStatusLbl);
            this.checkoutPanel.Controls.Add(this.checkoutStatusLbl);
            this.checkoutPanel.Controls.Add(this.pictureBox3);
            this.checkoutPanel.Controls.Add(this.labelVisitor);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Location = new System.Drawing.Point(176, 16);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1105, 687);
            this.checkoutPanel.TabIndex = 4;
            // 
            // labelVisitor
            // 
            this.labelVisitor.AutoSize = true;
            this.labelVisitor.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitor.Location = new System.Drawing.Point(265, 154);
            this.labelVisitor.Name = "labelVisitor";
            this.labelVisitor.Size = new System.Drawing.Size(121, 23);
            this.labelVisitor.TabIndex = 39;
            this.labelVisitor.Text = "Visitor info";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(518, 148);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(95, 23);
            this.labelStatusOut.TabIndex = 2;
            this.labelStatusOut.Text = "STATUS";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.logsClearBtn);
            this.searchPanel.Controls.Add(this.checkoutLogsBtn);
            this.searchPanel.Controls.Add(this.checkinLogsBtn);
            this.searchPanel.Controls.Add(this.viewLogsBtn);
            this.searchPanel.Controls.Add(this.logsInfoLbx);
            this.searchPanel.Controls.Add(this.reservationRbtn);
            this.searchPanel.Controls.Add(this.nameRbtn);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.textBoxSearch);
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Location = new System.Drawing.Point(176, 16);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1105, 687);
            this.searchPanel.TabIndex = 5;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(36, 73);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 22);
            this.labelMonitor.TabIndex = 29;
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
            this.buttonSearch.Location = new System.Drawing.Point(355, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(31, 22);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // webCamTimer
            // 
            this.webCamTimer.Tick += new System.EventHandler(this.webCamTimer_Tick);
            // 
            // checkinOverrideBtn
            // 
            this.checkinOverrideBtn.Location = new System.Drawing.Point(621, 529);
            this.checkinOverrideBtn.Name = "checkinOverrideBtn";
            this.checkinOverrideBtn.Size = new System.Drawing.Size(142, 52);
            this.checkinOverrideBtn.TabIndex = 58;
            this.checkinOverrideBtn.Text = "Override";
            this.checkinOverrideBtn.UseVisualStyleBackColor = true;
            // 
            // checkinClearBtn
            // 
            this.checkinClearBtn.Location = new System.Drawing.Point(388, 529);
            this.checkinClearBtn.Name = "checkinClearBtn";
            this.checkinClearBtn.Size = new System.Drawing.Size(142, 52);
            this.checkinClearBtn.TabIndex = 59;
            this.checkinClearBtn.Text = "Clear All";
            this.checkinClearBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 52);
            this.button3.TabIndex = 60;
            this.button3.Text = "User Details";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkinHistoryBtn
            // 
            this.checkinHistoryBtn.Location = new System.Drawing.Point(31, 529);
            this.checkinHistoryBtn.Name = "checkinHistoryBtn";
            this.checkinHistoryBtn.Size = new System.Drawing.Size(142, 52);
            this.checkinHistoryBtn.TabIndex = 61;
            this.checkinHistoryBtn.Text = "Check History";
            this.checkinHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // checkinInfoLbx
            // 
            this.checkinInfoLbx.FormattingEnabled = true;
            this.checkinInfoLbx.Location = new System.Drawing.Point(33, 350);
            this.checkinInfoLbx.Name = "checkinInfoLbx";
            this.checkinInfoLbx.Size = new System.Drawing.Size(404, 160);
            this.checkinInfoLbx.TabIndex = 57;
            // 
            // checkinLbl
            // 
            this.checkinLbl.AutoSize = true;
            this.checkinLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinLbl.Location = new System.Drawing.Point(49, 111);
            this.checkinLbl.Name = "checkinLbl";
            this.checkinLbl.Size = new System.Drawing.Size(194, 23);
            this.checkinLbl.TabIndex = 54;
            this.checkinLbl.Text = "Entrance Check In";
            // 
            // checkinMessageLbl
            // 
            this.checkinMessageLbl.AutoSize = true;
            this.checkinMessageLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinMessageLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinMessageLbl.Location = new System.Drawing.Point(447, 245);
            this.checkinMessageLbl.Name = "checkinMessageLbl";
            this.checkinMessageLbl.Size = new System.Drawing.Size(107, 23);
            this.checkinMessageLbl.TabIndex = 55;
            this.checkinMessageLbl.Text = "(message)";
            // 
            // checkinStatusLbl
            // 
            this.checkinStatusLbl.AutoSize = true;
            this.checkinStatusLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinStatusLbl.Location = new System.Drawing.Point(563, 186);
            this.checkinStatusLbl.Name = "checkinStatusLbl";
            this.checkinStatusLbl.Size = new System.Drawing.Size(110, 23);
            this.checkinStatusLbl.TabIndex = 56;
            this.checkinStatusLbl.Text = "(OK/NOK)";
            // 
            // checkoutOverrideBtn
            // 
            this.checkoutOverrideBtn.Location = new System.Drawing.Point(691, 491);
            this.checkoutOverrideBtn.Name = "checkoutOverrideBtn";
            this.checkoutOverrideBtn.Size = new System.Drawing.Size(142, 52);
            this.checkoutOverrideBtn.TabIndex = 47;
            this.checkoutOverrideBtn.Text = "Override";
            this.checkoutOverrideBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutClearBtn
            // 
            this.checkoutClearBtn.Location = new System.Drawing.Point(458, 491);
            this.checkoutClearBtn.Name = "checkoutClearBtn";
            this.checkoutClearBtn.Size = new System.Drawing.Size(142, 52);
            this.checkoutClearBtn.TabIndex = 48;
            this.checkoutClearBtn.Text = "Clear All";
            this.checkoutClearBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutDetailsBtn
            // 
            this.checkoutDetailsBtn.Location = new System.Drawing.Point(283, 491);
            this.checkoutDetailsBtn.Name = "checkoutDetailsBtn";
            this.checkoutDetailsBtn.Size = new System.Drawing.Size(142, 52);
            this.checkoutDetailsBtn.TabIndex = 49;
            this.checkoutDetailsBtn.Text = "User Details";
            this.checkoutDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutHistoryBtn
            // 
            this.checkoutHistoryBtn.Location = new System.Drawing.Point(101, 491);
            this.checkoutHistoryBtn.Name = "checkoutHistoryBtn";
            this.checkoutHistoryBtn.Size = new System.Drawing.Size(142, 52);
            this.checkoutHistoryBtn.TabIndex = 50;
            this.checkoutHistoryBtn.Text = "Check History";
            this.checkoutHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutInfoLbx
            // 
            this.checkoutInfoLbx.FormattingEnabled = true;
            this.checkoutInfoLbx.Location = new System.Drawing.Point(101, 316);
            this.checkoutInfoLbx.Name = "checkoutInfoLbx";
            this.checkoutInfoLbx.Size = new System.Drawing.Size(410, 160);
            this.checkoutInfoLbx.TabIndex = 46;
            // 
            // campingCheckoutLbl
            // 
            this.campingCheckoutLbl.AutoSize = true;
            this.campingCheckoutLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campingCheckoutLbl.ForeColor = System.Drawing.Color.DimGray;
            this.campingCheckoutLbl.Location = new System.Drawing.Point(119, 73);
            this.campingCheckoutLbl.Name = "campingCheckoutLbl";
            this.campingCheckoutLbl.Size = new System.Drawing.Size(207, 23);
            this.campingCheckoutLbl.TabIndex = 42;
            this.campingCheckoutLbl.Text = "Camping Check Out";
            // 
            // checkoutMessageLbl
            // 
            this.checkoutMessageLbl.AutoSize = true;
            this.checkoutMessageLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutMessageLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutMessageLbl.Location = new System.Drawing.Point(518, 184);
            this.checkoutMessageLbl.Name = "checkoutMessageLbl";
            this.checkoutMessageLbl.Size = new System.Drawing.Size(107, 23);
            this.checkoutMessageLbl.TabIndex = 43;
            this.checkoutMessageLbl.Text = "(message)";
            // 
            // checkoutStatusLbl
            // 
            this.checkoutStatusLbl.AutoSize = true;
            this.checkoutStatusLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutStatusLbl.Location = new System.Drawing.Point(633, 148);
            this.checkoutStatusLbl.Name = "checkoutStatusLbl";
            this.checkoutStatusLbl.Size = new System.Drawing.Size(110, 23);
            this.checkoutStatusLbl.TabIndex = 44;
            this.checkoutStatusLbl.Text = "(OK/NOK)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(128, 152);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 124);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // campsiteLbl
            // 
            this.campsiteLbl.AutoSize = true;
            this.campsiteLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campsiteLbl.ForeColor = System.Drawing.Color.DimGray;
            this.campsiteLbl.Location = new System.Drawing.Point(518, 222);
            this.campsiteLbl.Name = "campsiteLbl";
            this.campsiteLbl.Size = new System.Drawing.Size(103, 23);
            this.campsiteLbl.TabIndex = 43;
            this.campsiteLbl.Text = "Campsite";
            // 
            // rentalsLbl
            // 
            this.rentalsLbl.AutoSize = true;
            this.rentalsLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.rentalsLbl.Location = new System.Drawing.Point(518, 253);
            this.rentalsLbl.Name = "rentalsLbl";
            this.rentalsLbl.Size = new System.Drawing.Size(86, 23);
            this.rentalsLbl.TabIndex = 43;
            this.rentalsLbl.Text = "Rentals";
            // 
            // campsiteStatusLbl
            // 
            this.campsiteStatusLbl.AutoSize = true;
            this.campsiteStatusLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campsiteStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.campsiteStatusLbl.Location = new System.Drawing.Point(633, 222);
            this.campsiteStatusLbl.Name = "campsiteStatusLbl";
            this.campsiteStatusLbl.Size = new System.Drawing.Size(110, 23);
            this.campsiteStatusLbl.TabIndex = 44;
            this.campsiteStatusLbl.Text = "(OK/NOK)";
            // 
            // rentalStatusLbl
            // 
            this.rentalStatusLbl.AutoSize = true;
            this.rentalStatusLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.rentalStatusLbl.Location = new System.Drawing.Point(633, 255);
            this.rentalStatusLbl.Name = "rentalStatusLbl";
            this.rentalStatusLbl.Size = new System.Drawing.Size(110, 23);
            this.rentalStatusLbl.TabIndex = 44;
            this.rentalStatusLbl.Text = "(OK/NOK)";
            // 
            // logsClearBtn
            // 
            this.logsClearBtn.Location = new System.Drawing.Point(792, 508);
            this.logsClearBtn.Name = "logsClearBtn";
            this.logsClearBtn.Size = new System.Drawing.Size(124, 69);
            this.logsClearBtn.TabIndex = 41;
            this.logsClearBtn.Text = "Clear All";
            this.logsClearBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutLogsBtn
            // 
            this.checkoutLogsBtn.Location = new System.Drawing.Point(488, 508);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(124, 69);
            this.checkoutLogsBtn.TabIndex = 42;
            this.checkoutLogsBtn.Text = "Checked Out";
            this.checkoutLogsBtn.UseVisualStyleBackColor = true;
            // 
            // checkinLogsBtn
            // 
            this.checkinLogsBtn.Location = new System.Drawing.Point(312, 508);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(124, 69);
            this.checkinLogsBtn.TabIndex = 43;
            this.checkinLogsBtn.Text = "Checked In";
            this.checkinLogsBtn.UseVisualStyleBackColor = true;
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Location = new System.Drawing.Point(147, 508);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(124, 69);
            this.viewLogsBtn.TabIndex = 44;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.Location = new System.Drawing.Point(147, 238);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(517, 238);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // reservationRbtn
            // 
            this.reservationRbtn.AutoSize = true;
            this.reservationRbtn.Location = new System.Drawing.Point(132, 84);
            this.reservationRbtn.Name = "reservationRbtn";
            this.reservationRbtn.Size = new System.Drawing.Size(96, 17);
            this.reservationRbtn.TabIndex = 38;
            this.reservationRbtn.TabStop = true;
            this.reservationRbtn.Text = "Reservation Nr";
            this.reservationRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Location = new System.Drawing.Point(64, 84);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(53, 17);
            this.nameRbtn.TabIndex = 39;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(50, 105);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(83, 23);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(143, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "(error message)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(50, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Entrance Logs";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(147, 106);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(195, 20);
            this.textBoxSearch.TabIndex = 30;
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.checkinPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntranceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.panel1.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button buttonStartWC;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Label labelVisitor;
        private System.Windows.Forms.Button checkinOverrideBtn;
        private System.Windows.Forms.Button checkinClearBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button checkinHistoryBtn;
        private System.Windows.Forms.ListBox checkinInfoLbx;
        private System.Windows.Forms.Label checkinLbl;
        private System.Windows.Forms.Label checkinMessageLbl;
        private System.Windows.Forms.Label checkinStatusLbl;
        private System.Windows.Forms.Button checkoutOverrideBtn;
        private System.Windows.Forms.Button checkoutClearBtn;
        private System.Windows.Forms.Button checkoutDetailsBtn;
        private System.Windows.Forms.Button checkoutHistoryBtn;
        private System.Windows.Forms.ListBox checkoutInfoLbx;
        private System.Windows.Forms.Label campingCheckoutLbl;
        private System.Windows.Forms.Label rentalsLbl;
        private System.Windows.Forms.Label campsiteLbl;
        private System.Windows.Forms.Label checkoutMessageLbl;
        private System.Windows.Forms.Label rentalStatusLbl;
        private System.Windows.Forms.Label campsiteStatusLbl;
        private System.Windows.Forms.Label checkoutStatusLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button logsClearBtn;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton reservationRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}

