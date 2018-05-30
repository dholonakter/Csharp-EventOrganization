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
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.statusIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTagNr = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.ListBox();
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
            this.pictureBoxCaptured = new System.Windows.Forms.PictureBox();
            this.comboBoxCameraSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webCamTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).BeginInit();
            this.ticketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
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
            this.ticketsBtn.Text = "   Buy Tickets";
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
            this.checkinPanel.Controls.Add(this.statusIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.labelTagNr);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Location = new System.Drawing.Point(235, 20);
            this.checkinPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkinPanel.TabIndex = 3;
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
            this.pictureBox2.Location = new System.Drawing.Point(182, 187);
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
            this.lbCheckIn.Size = new System.Drawing.Size(565, 254);
            this.lbCheckIn.TabIndex = 1;
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
            this.statusOut.Location = new System.Drawing.Point(314, 363);
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
            this.labelStatusOut.Location = new System.Drawing.Point(180, 365);
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
            this.lbCheckOut.Size = new System.Drawing.Size(565, 429);
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
            this.buttonSaveChanges.Location = new System.Drawing.Point(176, 285);
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
            this.dataGridVisitor.Location = new System.Drawing.Point(53, 333);
            this.dataGridVisitor.Name = "dataGridVisitor";
            this.dataGridVisitor.RowTemplate.Height = 24;
            this.dataGridVisitor.Size = new System.Drawing.Size(1027, 429);
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
            this.label9.Location = new System.Drawing.Point(48, 56);
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
            this.listBoxSearch.Location = new System.Drawing.Point(54, 92);
            this.listBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(1026, 179);
            this.listBoxSearch.TabIndex = 1;
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.label3);
            this.ticketPanel.Controls.Add(this.pictureBoxCaptured);
            this.ticketPanel.Controls.Add(this.comboBoxCameraSource);
            this.ticketPanel.Controls.Add(this.label2);
            this.ticketPanel.Controls.Add(this.button3);
            this.ticketPanel.Controls.Add(this.pictureBoxSource);
            this.ticketPanel.Controls.Add(this.button2);
            this.ticketPanel.Controls.Add(this.button1);
            this.ticketPanel.Location = new System.Drawing.Point(231, 20);
            this.ticketPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1473, 846);
            this.ticketPanel.TabIndex = 10;
            // 
            // pictureBoxCaptured
            // 
            this.pictureBoxCaptured.Location = new System.Drawing.Point(1015, 164);
            this.pictureBoxCaptured.Name = "pictureBoxCaptured";
            this.pictureBoxCaptured.Size = new System.Drawing.Size(306, 249);
            this.pictureBoxCaptured.TabIndex = 6;
            this.pictureBoxCaptured.TabStop = false;
            // 
            // comboBoxCameraSource
            // 
            this.comboBoxCameraSource.FormattingEnabled = true;
            this.comboBoxCameraSource.Location = new System.Drawing.Point(443, 114);
            this.comboBoxCameraSource.Name = "comboBoxCameraSource";
            this.comboBoxCameraSource.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCameraSource.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Webcam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(654, 164);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(306, 249);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse/Capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webCamTimer
            // 
            this.webCamTimer.Tick += new System.EventHandler(this.webCamTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.searchPanel);
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
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisitor)).EndInit();
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCameraSource;
        private System.Windows.Forms.PictureBox pictureBoxCaptured;
        private System.Windows.Forms.Label label3;
    }
}

