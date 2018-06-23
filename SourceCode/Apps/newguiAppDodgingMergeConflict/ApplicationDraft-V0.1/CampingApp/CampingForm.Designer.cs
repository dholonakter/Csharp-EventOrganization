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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.logsClearBtn = new System.Windows.Forms.Button();
            this.checkoutLogsBtn = new System.Windows.Forms.Button();
            this.checkinLogsBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.reservationRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxResrvID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.checkoutOverrideBtn = new System.Windows.Forms.Button();
            this.checkoutClearBtn = new System.Windows.Forms.Button();
            this.checkoutDetailsBtn = new System.Windows.Forms.Button();
            this.checkoutHistoryBtn = new System.Windows.Forms.Button();
            this.checkoutInfoLbx = new System.Windows.Forms.ListBox();
            this.campingCheckoutLbl = new System.Windows.Forms.Label();
            this.checkoutMessageLbl = new System.Windows.Forms.Label();
            this.checkoutStatusLbl = new System.Windows.Forms.Label();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.checkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 788);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 933);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.checkinBtn.Location = new System.Drawing.Point(15, 110);
            this.checkinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(207, 66);
            this.checkinBtn.TabIndex = 12;
            this.checkinBtn.Text = "Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
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
            this.monitorBtn.Location = new System.Drawing.Point(15, 334);
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 66);
            this.monitorBtn.TabIndex = 13;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 110);
            this.sideHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(15, 66);
            this.sideHighlight.TabIndex = 14;
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
            this.checkoutBtn.Location = new System.Drawing.Point(15, 223);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(207, 66);
            this.checkoutBtn.TabIndex = 14;
            this.checkoutBtn.Text = "  Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
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
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Controls.Add(this.textBoxResrvID);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Location = new System.Drawing.Point(221, 15);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1941, 846);
            this.searchPanel.TabIndex = 6;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // logsClearBtn
            // 
            this.logsClearBtn.Location = new System.Drawing.Point(984, 576);
            this.logsClearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsClearBtn.Name = "logsClearBtn";
            this.logsClearBtn.Size = new System.Drawing.Size(165, 85);
            this.logsClearBtn.TabIndex = 31;
            this.logsClearBtn.Text = "Clear All";
            this.logsClearBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutLogsBtn
            // 
            this.checkoutLogsBtn.Location = new System.Drawing.Point(579, 576);
            this.checkoutLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(165, 85);
            this.checkoutLogsBtn.TabIndex = 31;
            this.checkoutLogsBtn.Text = "Checked Out";
            this.checkoutLogsBtn.UseVisualStyleBackColor = true;
            // 
            // checkinLogsBtn
            // 
            this.checkinLogsBtn.Location = new System.Drawing.Point(344, 576);
            this.checkinLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(165, 85);
            this.checkinLogsBtn.TabIndex = 31;
            this.checkinLogsBtn.Text = "Checked In";
            this.checkinLogsBtn.UseVisualStyleBackColor = true;
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Location = new System.Drawing.Point(124, 576);
            this.viewLogsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(165, 85);
            this.viewLogsBtn.TabIndex = 31;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 16;
            this.logsInfoLbx.Location = new System.Drawing.Point(124, 244);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(688, 292);
            this.logsInfoLbx.TabIndex = 30;
            // 
            // reservationRbtn
            // 
            this.reservationRbtn.AutoSize = true;
            this.reservationRbtn.Location = new System.Drawing.Point(148, 87);
            this.reservationRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationRbtn.Name = "reservationRbtn";
            this.reservationRbtn.Size = new System.Drawing.Size(124, 21);
            this.reservationRbtn.TabIndex = 29;
            this.reservationRbtn.TabStop = true;
            this.reservationRbtn.Text = "Reservation Nr";
            this.reservationRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Location = new System.Drawing.Point(49, 87);
            this.nameRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(66, 21);
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
            this.labelMonitor.Location = new System.Drawing.Point(44, 130);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 28;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(9, 116);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(103, 28);
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
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(383, 113);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(36, 37);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxResrvID
            // 
            this.textBoxResrvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResrvID.Location = new System.Drawing.Point(124, 119);
            this.textBoxResrvID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResrvID.Name = "textBoxResrvID";
            this.textBoxResrvID.Size = new System.Drawing.Size(249, 26);
            this.textBoxResrvID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(119, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "(error message)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(43, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Camping Logs";
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.checkoutOverrideBtn);
            this.checkoutPanel.Controls.Add(this.checkoutClearBtn);
            this.checkoutPanel.Controls.Add(this.checkoutDetailsBtn);
            this.checkoutPanel.Controls.Add(this.checkoutHistoryBtn);
            this.checkoutPanel.Controls.Add(this.checkoutInfoLbx);
            this.checkoutPanel.Controls.Add(this.campingCheckoutLbl);
            this.checkoutPanel.Controls.Add(this.checkoutMessageLbl);
            this.checkoutPanel.Controls.Add(this.checkoutStatusLbl);
            this.checkoutPanel.Controls.Add(this.lbCheckOut);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Controls.Add(this.pictureBox1);
            this.checkoutPanel.Location = new System.Drawing.Point(221, 15);
            this.checkoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkoutPanel.TabIndex = 7;
            // 
            // checkoutOverrideBtn
            // 
            this.checkoutOverrideBtn.Location = new System.Drawing.Point(976, 668);
            this.checkoutOverrideBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutOverrideBtn.Name = "checkoutOverrideBtn";
            this.checkoutOverrideBtn.Size = new System.Drawing.Size(189, 64);
            this.checkoutOverrideBtn.TabIndex = 38;
            this.checkoutOverrideBtn.Text = "Override";
            this.checkoutOverrideBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutClearBtn
            // 
            this.checkoutClearBtn.Location = new System.Drawing.Point(665, 668);
            this.checkoutClearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutClearBtn.Name = "checkoutClearBtn";
            this.checkoutClearBtn.Size = new System.Drawing.Size(189, 64);
            this.checkoutClearBtn.TabIndex = 38;
            this.checkoutClearBtn.Text = "Clear All";
            this.checkoutClearBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutDetailsBtn
            // 
            this.checkoutDetailsBtn.Location = new System.Drawing.Point(432, 668);
            this.checkoutDetailsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutDetailsBtn.Name = "checkoutDetailsBtn";
            this.checkoutDetailsBtn.Size = new System.Drawing.Size(189, 64);
            this.checkoutDetailsBtn.TabIndex = 38;
            this.checkoutDetailsBtn.Text = "User Details";
            this.checkoutDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutHistoryBtn
            // 
            this.checkoutHistoryBtn.Location = new System.Drawing.Point(189, 668);
            this.checkoutHistoryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutHistoryBtn.Name = "checkoutHistoryBtn";
            this.checkoutHistoryBtn.Size = new System.Drawing.Size(189, 64);
            this.checkoutHistoryBtn.TabIndex = 38;
            this.checkoutHistoryBtn.Text = "Check History";
            this.checkoutHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutInfoLbx
            // 
            this.checkoutInfoLbx.FormattingEnabled = true;
            this.checkoutInfoLbx.ItemHeight = 16;
            this.checkoutInfoLbx.Location = new System.Drawing.Point(189, 453);
            this.checkoutInfoLbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutInfoLbx.Name = "checkoutInfoLbx";
            this.checkoutInfoLbx.Size = new System.Drawing.Size(567, 196);
            this.checkoutInfoLbx.TabIndex = 37;
            // 
            // campingCheckoutLbl
            // 
            this.campingCheckoutLbl.AutoSize = true;
            this.campingCheckoutLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campingCheckoutLbl.ForeColor = System.Drawing.Color.DimGray;
            this.campingCheckoutLbl.Location = new System.Drawing.Point(213, 154);
            this.campingCheckoutLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campingCheckoutLbl.Name = "campingCheckoutLbl";
            this.campingCheckoutLbl.Size = new System.Drawing.Size(256, 28);
            this.campingCheckoutLbl.TabIndex = 36;
            this.campingCheckoutLbl.Text = "Camping Check Out";
            // 
            // checkoutMessageLbl
            // 
            this.checkoutMessageLbl.AutoSize = true;
            this.checkoutMessageLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutMessageLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutMessageLbl.Location = new System.Drawing.Point(744, 319);
            this.checkoutMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutMessageLbl.Name = "checkoutMessageLbl";
            this.checkoutMessageLbl.Size = new System.Drawing.Size(130, 28);
            this.checkoutMessageLbl.TabIndex = 36;
            this.checkoutMessageLbl.Text = "(message)";
            // 
            // checkoutStatusLbl
            // 
            this.checkoutStatusLbl.AutoSize = true;
            this.checkoutStatusLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutStatusLbl.Location = new System.Drawing.Point(899, 246);
            this.checkoutStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutStatusLbl.Name = "checkoutStatusLbl";
            this.checkoutStatusLbl.Size = new System.Drawing.Size(139, 28);
            this.checkoutStatusLbl.TabIndex = 36;
            this.checkoutStatusLbl.Text = "(OK/NOK)";
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.ForeColor = System.Drawing.Color.DimGray;
            this.lbCheckOut.Location = new System.Drawing.Point(427, 251);
            this.lbCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(77, 28);
            this.lbCheckOut.TabIndex = 36;
            this.lbCheckOut.Text = "(info)";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(744, 251);
            this.labelStatusOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(117, 28);
            this.labelStatusOut.TabIndex = 34;
            this.labelStatusOut.Text = "STATUS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(225, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 153);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 12);
            this.panel2.TabIndex = 1;
            // 
            // CampingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.checkoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBoxResrvID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label campingCheckoutLbl;
        private System.Windows.Forms.Label checkoutStatusLbl;
        private System.Windows.Forms.Button checkoutOverrideBtn;
        private System.Windows.Forms.Button checkoutClearBtn;
        private System.Windows.Forms.Button checkoutDetailsBtn;
        private System.Windows.Forms.Button checkoutHistoryBtn;
        private System.Windows.Forms.ListBox checkoutInfoLbx;
        private System.Windows.Forms.Label checkoutMessageLbl;
        private System.Windows.Forms.Button logsClearBtn;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton reservationRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Label label2;
    }
}

