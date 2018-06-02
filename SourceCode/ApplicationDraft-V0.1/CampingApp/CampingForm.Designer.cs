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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.statusIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTagNr = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.ListBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxResrvID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxMonitor = new System.Windows.Forms.ListBox();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxCheckOut = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCamp = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.checkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 945);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(221, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkinBtn.Margin = new System.Windows.Forms.Padding(4);
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
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 66);
            this.monitorBtn.TabIndex = 13;
            this.monitorBtn.Text = "    Monitoring";
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
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(207, 66);
            this.checkoutBtn.TabIndex = 14;
            this.checkoutBtn.Text = "  Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 12);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.statusIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.labelTagNr);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.buttonPay);
            this.checkinPanel.Location = new System.Drawing.Point(295, 85);
            this.checkinPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkinPanel.TabIndex = 5;
            // 
            // statusIn
            // 
            this.statusIn.BackColor = System.Drawing.Color.White;
            this.statusIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusIn.ForeColor = System.Drawing.Color.DimGray;
            this.statusIn.Image = ((System.Drawing.Image)(resources.GetObject("statusIn.Image")));
            this.statusIn.Location = new System.Drawing.Point(222, 338);
            this.statusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusIn.Name = "statusIn";
            this.statusIn.Size = new System.Drawing.Size(44, 31);
            this.statusIn.TabIndex = 26;
            this.statusIn.Text = "      ";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(88, 340);
            this.labelStatusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(117, 28);
            this.labelStatusIn.TabIndex = 25;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(92, 169);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 153);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // labelTagNr
            // 
            this.labelTagNr.AutoSize = true;
            this.labelTagNr.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagNr.ForeColor = System.Drawing.Color.DimGray;
            this.labelTagNr.Location = new System.Drawing.Point(88, 382);
            this.labelTagNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagNr.Name = "labelTagNr";
            this.labelTagNr.Size = new System.Drawing.Size(163, 28);
            this.labelTagNr.TabIndex = 23;
            this.labelTagNr.Text = "Tag Number";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.FormattingEnabled = true;
            this.lbCheckIn.HorizontalScrollbar = true;
            this.lbCheckIn.ItemHeight = 25;
            this.lbCheckIn.Location = new System.Drawing.Point(311, 169);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(565, 229);
            this.lbCheckIn.TabIndex = 22;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.Location = new System.Drawing.Point(908, 290);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(160, 65);
            this.buttonPay.TabIndex = 10;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.buttonSaveChanges);
            this.searchPanel.Controls.Add(this.dataGridViewCamp);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Controls.Add(this.textBoxResrvID);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.listBoxMonitor);
            this.searchPanel.Location = new System.Drawing.Point(276, 81);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1942, 846);
            this.searchPanel.TabIndex = 6;
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
            this.buttonSearch.Location = new System.Drawing.Point(313, 80);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(36, 37);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxResrvID
            // 
            this.textBoxResrvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResrvID.Location = new System.Drawing.Point(49, 85);
            this.textBoxResrvID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResrvID.Name = "textBoxResrvID";
            this.textBoxResrvID.Size = new System.Drawing.Size(249, 26);
            this.textBoxResrvID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(43, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enter Reservation ID ";
            // 
            // listBoxMonitor
            // 
            this.listBoxMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMonitor.FormattingEnabled = true;
            this.listBoxMonitor.HorizontalScrollbar = true;
            this.listBoxMonitor.ItemHeight = 25;
            this.listBoxMonitor.Location = new System.Drawing.Point(49, 129);
            this.listBoxMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMonitor.Name = "listBoxMonitor";
            this.listBoxMonitor.Size = new System.Drawing.Size(1250, 225);
            this.listBoxMonitor.TabIndex = 1;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.label6);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Controls.Add(this.pictureBox1);
            this.checkoutPanel.Controls.Add(this.listBoxCheckOut);
            this.checkoutPanel.Location = new System.Drawing.Point(280, 78);
            this.checkoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkoutPanel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(357, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "      ";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(223, 474);
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
            this.pictureBox1.Location = new System.Drawing.Point(227, 303);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 153);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxCheckOut
            // 
            this.listBoxCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCheckOut.FormattingEnabled = true;
            this.listBoxCheckOut.HorizontalScrollbar = true;
            this.listBoxCheckOut.ItemHeight = 25;
            this.listBoxCheckOut.Location = new System.Drawing.Point(446, 303);
            this.listBoxCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCheckOut.Name = "listBoxCheckOut";
            this.listBoxCheckOut.Size = new System.Drawing.Size(565, 229);
            this.listBoxCheckOut.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(42, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monitor";
            // 
            // dataGridViewCamp
            // 
            this.dataGridViewCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamp.Location = new System.Drawing.Point(45, 427);
            this.dataGridViewCamp.Name = "dataGridViewCamp";
            this.dataGridViewCamp.RowTemplate.Height = 24;
            this.dataGridViewCamp.Size = new System.Drawing.Size(1251, 328);
            this.dataGridViewCamp.TabIndex = 15;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(169, 374);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(81, 28);
            this.buttonSaveChanges.TabIndex = 18;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // CampingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CampingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CampingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxResrvID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxMonitor;
        private System.Windows.Forms.Label statusIn;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTagNr;
        private System.Windows.Forms.ListBox lbCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCamp;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}

