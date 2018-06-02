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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.statusIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTagNr = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.ListBox();
            this.buttonStartWC = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusOut = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.lbCheckOut = new System.Windows.Forms.ListBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVisitor = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxVisitorNrSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.cbxSelectedAmount = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.webCamTimer = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).BeginInit();
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.ticketsBtn);
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 945);
            this.panel1.TabIndex = 0;
            // 
            // ticketsBtn
            // 
            this.ticketsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ticketsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ticketsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ticketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsBtn.ForeColor = System.Drawing.Color.White;
            this.ticketsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBtn.Image")));
            this.ticketsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticketsBtn.Location = new System.Drawing.Point(16, 110);
            this.ticketsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ticketsBtn.Name = "ticketsBtn";
            this.ticketsBtn.Size = new System.Drawing.Size(207, 66);
            this.ticketsBtn.TabIndex = 12;
            this.ticketsBtn.Text = "Tickets";
            this.ticketsBtn.UseVisualStyleBackColor = true;
            this.ticketsBtn.Click += new System.EventHandler(this.ticketsBtn_Click);
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
            this.checkinBtn.Location = new System.Drawing.Point(16, 223);
            this.checkinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(207, 66);
            this.checkinBtn.TabIndex = 9;
            this.checkinBtn.Text = "Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
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
            this.monitorBtn.Location = new System.Drawing.Point(16, 447);
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 66);
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
            this.checkoutBtn.Location = new System.Drawing.Point(16, 336);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(207, 66);
            this.checkoutBtn.TabIndex = 11;
            this.checkoutBtn.Text = "   Check Out";
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
            this.checkinPanel.Controls.Add(this.button2);
            this.checkinPanel.Controls.Add(this.statusIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.labelTagNr);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.buttonStartWC);
            this.checkinPanel.Controls.Add(this.pictureBoxSource);
            this.checkinPanel.Location = new System.Drawing.Point(235, 20);
            this.checkinPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkinPanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(946, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 49);
            this.button2.TabIndex = 30;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusIn
            // 
            this.statusIn.BackColor = System.Drawing.Color.White;
            this.statusIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusIn.ForeColor = System.Drawing.Color.DimGray;
            this.statusIn.Image = ((System.Drawing.Image)(resources.GetObject("statusIn.Image")));
            this.statusIn.Location = new System.Drawing.Point(311, 356);
            this.statusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusIn.Name = "statusIn";
            this.statusIn.Size = new System.Drawing.Size(44, 31);
            this.statusIn.TabIndex = 21;
            this.statusIn.Text = "      ";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(177, 358);
            this.labelStatusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(117, 28);
            this.labelStatusIn.TabIndex = 20;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(181, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 153);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // labelTagNr
            // 
            this.labelTagNr.AutoSize = true;
            this.labelTagNr.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagNr.ForeColor = System.Drawing.Color.DimGray;
            this.labelTagNr.Location = new System.Drawing.Point(177, 400);
            this.labelTagNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagNr.Name = "labelTagNr";
            this.labelTagNr.Size = new System.Drawing.Size(163, 28);
            this.labelTagNr.TabIndex = 2;
            this.labelTagNr.Text = "Tag Number";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.FormattingEnabled = true;
            this.lbCheckIn.HorizontalScrollbar = true;
            this.lbCheckIn.ItemHeight = 25;
            this.lbCheckIn.Location = new System.Drawing.Point(483, 187);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(437, 229);
            this.lbCheckIn.TabIndex = 1;
            // 
            // buttonStartWC
            // 
            this.buttonStartWC.Location = new System.Drawing.Point(516, 486);
            this.buttonStartWC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartWC.Name = "buttonStartWC";
            this.buttonStartWC.Size = new System.Drawing.Size(205, 62);
            this.buttonStartWC.TabIndex = 3;
            this.buttonStartWC.Text = "Start webcam";
            this.buttonStartWC.UseVisualStyleBackColor = true;
            this.buttonStartWC.Click += new System.EventHandler(this.buttonStartWC_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(176, 461);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(284, 249);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.pictureBox1);
            this.checkoutPanel.Controls.Add(this.statusOut);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Controls.Add(this.lbCheckOut);
            this.checkoutPanel.Location = new System.Drawing.Point(235, 20);
            this.checkoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkoutPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(185, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 153);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // statusOut
            // 
            this.statusOut.BackColor = System.Drawing.Color.White;
            this.statusOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOut.ForeColor = System.Drawing.Color.DimGray;
            this.statusOut.Image = ((System.Drawing.Image)(resources.GetObject("statusOut.Image")));
            this.statusOut.Location = new System.Drawing.Point(315, 363);
            this.statusOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusOut.Name = "statusOut";
            this.statusOut.Size = new System.Drawing.Size(44, 31);
            this.statusOut.TabIndex = 3;
            this.statusOut.Text = "      ";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(180, 366);
            this.labelStatusOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(117, 28);
            this.labelStatusOut.TabIndex = 2;
            this.labelStatusOut.Text = "STATUS";
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.FormattingEnabled = true;
            this.lbCheckOut.ItemHeight = 25;
            this.lbCheckOut.Location = new System.Drawing.Point(439, 187);
            this.lbCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(565, 404);
            this.lbCheckOut.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.buttonSaveChanges);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.dataGridVisitor);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Controls.Add(this.textBoxVisitorNrSearch);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.listBoxSearch);
            this.searchPanel.Location = new System.Drawing.Point(235, 20);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1473, 846);
            this.searchPanel.TabIndex = 5;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(176, 286);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(81, 28);
            this.buttonSaveChanges.TabIndex = 17;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(48, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Visitors";
            // 
            // dataGridVisitor
            // 
            this.dataGridVisitor.AllowUserToDeleteRows = false;
            this.dataGridVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisitor.Location = new System.Drawing.Point(53, 334);
            this.dataGridVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridVisitor.Name = "dataGridVisitor";
            this.dataGridVisitor.RowTemplate.Height = 24;
            this.dataGridVisitor.Size = new System.Drawing.Size(1027, 430);
            this.dataGridVisitor.TabIndex = 15;
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
            this.buttonSearch.Location = new System.Drawing.Point(541, 57);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 27);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxVisitorNrSearch
            // 
            this.textBoxVisitorNrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVisitorNrSearch.Location = new System.Drawing.Point(284, 57);
            this.textBoxVisitorNrSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVisitorNrSearch.Name = "textBoxVisitorNrSearch";
            this.textBoxVisitorNrSearch.Size = new System.Drawing.Size(249, 26);
            this.textBoxVisitorNrSearch.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(48, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enter Visitor ID ";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.HorizontalScrollbar = true;
            this.listBoxSearch.ItemHeight = 25;
            this.listBoxSearch.Location = new System.Drawing.Point(53, 92);
            this.listBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(1025, 154);
            this.listBoxSearch.TabIndex = 1;
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.cbxSelectedAmount);
            this.ticketPanel.Controls.Add(this.textBox1);
            this.ticketPanel.Controls.Add(this.tbName);
            this.ticketPanel.Controls.Add(this.label4);
            this.ticketPanel.Controls.Add(this.label12);
            this.ticketPanel.Controls.Add(this.label5);
            this.ticketPanel.Controls.Add(this.label7);
            this.ticketPanel.Controls.Add(this.label6);
            this.ticketPanel.Controls.Add(this.tbPhoneNumber);
            this.ticketPanel.Controls.Add(this.tbEmailAddress);
            this.ticketPanel.Location = new System.Drawing.Point(231, 20);
            this.ticketPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1473, 911);
            this.ticketPanel.TabIndex = 10;
            // 
            // cbxSelectedAmount
            // 
            this.cbxSelectedAmount.FormattingEnabled = true;
            this.cbxSelectedAmount.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "50"});
            this.cbxSelectedAmount.Location = new System.Drawing.Point(343, 367);
            this.cbxSelectedAmount.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSelectedAmount.Name = "cbxSelectedAmount";
            this.cbxSelectedAmount.Size = new System.Drawing.Size(272, 24);
            this.cbxSelectedAmount.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 26;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(343, 227);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(272, 22);
            this.tbName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "TopUp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "First Name";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(343, 316);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(272, 22);
            this.tbPhoneNumber.TabIndex = 31;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(343, 275);
            this.tbEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(272, 22);
            this.tbEmailAddress.TabIndex = 30;
            // 
            // webCamTimer
            // 
            this.webCamTimer.Tick += new System.EventHandler(this.webCamTimer_Tick);
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).EndInit();
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button ticketsBtn;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Label labelTagNr;
        private System.Windows.Forms.ListBox lbCheckIn;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label statusOut;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.ListBox lbCheckOut;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox textBoxVisitorNrSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.Label statusIn;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVisitor;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button buttonStartWC;
        private System.Windows.Forms.ComboBox cbxSelectedAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Button button2;
    }
}

