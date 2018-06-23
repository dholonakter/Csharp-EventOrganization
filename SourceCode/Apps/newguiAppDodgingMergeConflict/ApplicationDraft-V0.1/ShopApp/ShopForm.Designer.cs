namespace ShopApp
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.stockBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productLabel9 = new System.Windows.Forms.Label();
            this.productLabel10 = new System.Windows.Forms.Label();
            this.productLabel11 = new System.Windows.Forms.Label();
            this.productLabel12 = new System.Windows.Forms.Label();
            this.productLabel5 = new System.Windows.Forms.Label();
            this.productLabel6 = new System.Windows.Forms.Label();
            this.productLabel8 = new System.Windows.Forms.Label();
            this.productLabel7 = new System.Windows.Forms.Label();
            this.productLabel4 = new System.Windows.Forms.Label();
            this.productLabel3 = new System.Windows.Forms.Label();
            this.productLabel1 = new System.Windows.Forms.Label();
            this.productLabel2 = new System.Windows.Forms.Label();
            this.productButton9 = new System.Windows.Forms.Button();
            this.productButton10 = new System.Windows.Forms.Button();
            this.productButton11 = new System.Windows.Forms.Button();
            this.productButton12 = new System.Windows.Forms.Button();
            this.productButton5 = new System.Windows.Forms.Button();
            this.productButton6 = new System.Windows.Forms.Button();
            this.productButton7 = new System.Windows.Forms.Button();
            this.productButton8 = new System.Windows.Forms.Button();
            this.productButton4 = new System.Windows.Forms.Button();
            this.productButton3 = new System.Windows.Forms.Button();
            this.productButton2 = new System.Windows.Forms.Button();
            this.productButton1 = new System.Windows.Forms.Button();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logsClearBtn = new System.Windows.Forms.Button();
            this.restockBtn = new System.Windows.Forms.Button();
            this.viewStockBtn = new System.Windows.Forms.Button();
            this.viewHistoryBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchStockLbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxResrvID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.restockLbl = new System.Windows.Forms.Label();
            this.stockLogsLbl = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.stockBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 945);
            this.panel1.TabIndex = 0;
            // 
            // orderBtn
            // 
            this.orderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.orderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderBtn.Image")));
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(15, 110);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(207, 66);
            this.orderBtn.TabIndex = 15;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.overviewBtn_Click);
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
            // stockBtn
            // 
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.stockBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ForeColor = System.Drawing.Color.White;
            this.stockBtn.Image = ((System.Drawing.Image)(resources.GetObject("stockBtn.Image")));
            this.stockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.Location = new System.Drawing.Point(15, 223);
            this.stockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(207, 66);
            this.stockBtn.TabIndex = 17;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            // productPanel
            // 
            this.productPanel.Controls.Add(this.buttonIncrease);
            this.productPanel.Controls.Add(this.buttonConfirm);
            this.productPanel.Controls.Add(this.buttonDecrease);
            this.productPanel.Controls.Add(this.productLabel9);
            this.productPanel.Controls.Add(this.productLabel10);
            this.productPanel.Controls.Add(this.productLabel11);
            this.productPanel.Controls.Add(this.productLabel12);
            this.productPanel.Controls.Add(this.productLabel5);
            this.productPanel.Controls.Add(this.productLabel6);
            this.productPanel.Controls.Add(this.productLabel8);
            this.productPanel.Controls.Add(this.productLabel7);
            this.productPanel.Controls.Add(this.productLabel4);
            this.productPanel.Controls.Add(this.productLabel3);
            this.productPanel.Controls.Add(this.productLabel1);
            this.productPanel.Controls.Add(this.productLabel2);
            this.productPanel.Controls.Add(this.productButton9);
            this.productPanel.Controls.Add(this.productButton10);
            this.productPanel.Controls.Add(this.productButton11);
            this.productPanel.Controls.Add(this.productButton12);
            this.productPanel.Controls.Add(this.productButton5);
            this.productPanel.Controls.Add(this.productButton6);
            this.productPanel.Controls.Add(this.productButton7);
            this.productPanel.Controls.Add(this.productButton8);
            this.productPanel.Controls.Add(this.productButton4);
            this.productPanel.Controls.Add(this.productButton3);
            this.productPanel.Controls.Add(this.productButton2);
            this.productPanel.Controls.Add(this.productButton1);
            this.productPanel.Controls.Add(this.labelOrderInfo);
            this.productPanel.Controls.Add(this.itemLbx);
            this.productPanel.Controls.Add(this.labelOrder);
            this.productPanel.Location = new System.Drawing.Point(307, 86);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1329, 780);
            this.productPanel.TabIndex = 4;
            // 
            // productLabel9
            // 
            this.productLabel9.AutoSize = true;
            this.productLabel9.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel9.ForeColor = System.Drawing.Color.Black;
            this.productLabel9.Location = new System.Drawing.Point(53, 622);
            this.productLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel9.Name = "productLabel9";
            this.productLabel9.Size = new System.Drawing.Size(85, 23);
            this.productLabel9.TabIndex = 58;
            this.productLabel9.Text = "Order #";
            // 
            // productLabel10
            // 
            this.productLabel10.AutoSize = true;
            this.productLabel10.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel10.ForeColor = System.Drawing.Color.Black;
            this.productLabel10.Location = new System.Drawing.Point(246, 622);
            this.productLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel10.Name = "productLabel10";
            this.productLabel10.Size = new System.Drawing.Size(85, 23);
            this.productLabel10.TabIndex = 57;
            this.productLabel10.Text = "Order #";
            // 
            // productLabel11
            // 
            this.productLabel11.AutoSize = true;
            this.productLabel11.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel11.ForeColor = System.Drawing.Color.Black;
            this.productLabel11.Location = new System.Drawing.Point(632, 622);
            this.productLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel11.Name = "productLabel11";
            this.productLabel11.Size = new System.Drawing.Size(85, 23);
            this.productLabel11.TabIndex = 55;
            this.productLabel11.Text = "Order #";
            // 
            // productLabel12
            // 
            this.productLabel12.AutoSize = true;
            this.productLabel12.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel12.ForeColor = System.Drawing.Color.Black;
            this.productLabel12.Location = new System.Drawing.Point(438, 622);
            this.productLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel12.Name = "productLabel12";
            this.productLabel12.Size = new System.Drawing.Size(85, 23);
            this.productLabel12.TabIndex = 56;
            this.productLabel12.Text = "Order #";
            // 
            // productLabel5
            // 
            this.productLabel5.AutoSize = true;
            this.productLabel5.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel5.ForeColor = System.Drawing.Color.Black;
            this.productLabel5.Location = new System.Drawing.Point(55, 431);
            this.productLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel5.Name = "productLabel5";
            this.productLabel5.Size = new System.Drawing.Size(85, 23);
            this.productLabel5.TabIndex = 54;
            this.productLabel5.Text = "Order #";
            // 
            // productLabel6
            // 
            this.productLabel6.AutoSize = true;
            this.productLabel6.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel6.ForeColor = System.Drawing.Color.Black;
            this.productLabel6.Location = new System.Drawing.Point(248, 431);
            this.productLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel6.Name = "productLabel6";
            this.productLabel6.Size = new System.Drawing.Size(85, 23);
            this.productLabel6.TabIndex = 53;
            this.productLabel6.Text = "Order #";
            // 
            // productLabel8
            // 
            this.productLabel8.AutoSize = true;
            this.productLabel8.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel8.ForeColor = System.Drawing.Color.Black;
            this.productLabel8.Location = new System.Drawing.Point(634, 431);
            this.productLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel8.Name = "productLabel8";
            this.productLabel8.Size = new System.Drawing.Size(85, 23);
            this.productLabel8.TabIndex = 51;
            this.productLabel8.Text = "Order #";
            // 
            // productLabel7
            // 
            this.productLabel7.AutoSize = true;
            this.productLabel7.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel7.ForeColor = System.Drawing.Color.Black;
            this.productLabel7.Location = new System.Drawing.Point(438, 431);
            this.productLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel7.Name = "productLabel7";
            this.productLabel7.Size = new System.Drawing.Size(85, 23);
            this.productLabel7.TabIndex = 52;
            this.productLabel7.Text = "Order #";
            // 
            // productLabel4
            // 
            this.productLabel4.AutoSize = true;
            this.productLabel4.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel4.ForeColor = System.Drawing.Color.Black;
            this.productLabel4.Location = new System.Drawing.Point(632, 255);
            this.productLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel4.Name = "productLabel4";
            this.productLabel4.Size = new System.Drawing.Size(85, 23);
            this.productLabel4.TabIndex = 50;
            this.productLabel4.Text = "Order #";
            // 
            // productLabel3
            // 
            this.productLabel3.AutoSize = true;
            this.productLabel3.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel3.ForeColor = System.Drawing.Color.Black;
            this.productLabel3.Location = new System.Drawing.Point(440, 255);
            this.productLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel3.Name = "productLabel3";
            this.productLabel3.Size = new System.Drawing.Size(85, 23);
            this.productLabel3.TabIndex = 49;
            this.productLabel3.Text = "Order #";
            // 
            // productLabel1
            // 
            this.productLabel1.AutoSize = true;
            this.productLabel1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel1.ForeColor = System.Drawing.Color.Black;
            this.productLabel1.Location = new System.Drawing.Point(55, 255);
            this.productLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel1.Name = "productLabel1";
            this.productLabel1.Size = new System.Drawing.Size(85, 23);
            this.productLabel1.TabIndex = 47;
            this.productLabel1.Text = "Order #";
            // 
            // productLabel2
            // 
            this.productLabel2.AutoSize = true;
            this.productLabel2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel2.ForeColor = System.Drawing.Color.Black;
            this.productLabel2.Location = new System.Drawing.Point(246, 255);
            this.productLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel2.Name = "productLabel2";
            this.productLabel2.Size = new System.Drawing.Size(85, 23);
            this.productLabel2.TabIndex = 48;
            this.productLabel2.Text = "Order #";
            // 
            // productButton9
            // 
            this.productButton9.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton9.Image = ((System.Drawing.Image)(resources.GetObject("productButton9.Image")));
            this.productButton9.Location = new System.Drawing.Point(59, 493);
            this.productButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton9.Name = "productButton9";
            this.productButton9.Size = new System.Drawing.Size(165, 116);
            this.productButton9.TabIndex = 46;
            this.productButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton9.UseVisualStyleBackColor = false;
            this.productButton9.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton10
            // 
            this.productButton10.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton10.Image = ((System.Drawing.Image)(resources.GetObject("productButton10.Image")));
            this.productButton10.Location = new System.Drawing.Point(252, 493);
            this.productButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton10.Name = "productButton10";
            this.productButton10.Size = new System.Drawing.Size(165, 116);
            this.productButton10.TabIndex = 45;
            this.productButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton10.UseVisualStyleBackColor = false;
            this.productButton10.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton11
            // 
            this.productButton11.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton11.Image = ((System.Drawing.Image)(resources.GetObject("productButton11.Image")));
            this.productButton11.Location = new System.Drawing.Point(444, 493);
            this.productButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton11.Name = "productButton11";
            this.productButton11.Size = new System.Drawing.Size(165, 116);
            this.productButton11.TabIndex = 44;
            this.productButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton11.UseVisualStyleBackColor = false;
            this.productButton11.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton12
            // 
            this.productButton12.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton12.Image = ((System.Drawing.Image)(resources.GetObject("productButton12.Image")));
            this.productButton12.Location = new System.Drawing.Point(636, 493);
            this.productButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton12.Name = "productButton12";
            this.productButton12.Size = new System.Drawing.Size(165, 116);
            this.productButton12.TabIndex = 43;
            this.productButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton12.UseVisualStyleBackColor = false;
            this.productButton12.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton5
            // 
            this.productButton5.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton5.Image = ((System.Drawing.Image)(resources.GetObject("productButton5.Image")));
            this.productButton5.Location = new System.Drawing.Point(59, 301);
            this.productButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton5.Name = "productButton5";
            this.productButton5.Size = new System.Drawing.Size(165, 116);
            this.productButton5.TabIndex = 42;
            this.productButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton5.UseVisualStyleBackColor = false;
            this.productButton5.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton6
            // 
            this.productButton6.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton6.Image = ((System.Drawing.Image)(resources.GetObject("productButton6.Image")));
            this.productButton6.Location = new System.Drawing.Point(252, 301);
            this.productButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton6.Name = "productButton6";
            this.productButton6.Size = new System.Drawing.Size(165, 116);
            this.productButton6.TabIndex = 41;
            this.productButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton6.UseVisualStyleBackColor = false;
            this.productButton6.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton7
            // 
            this.productButton7.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton7.Image = ((System.Drawing.Image)(resources.GetObject("productButton7.Image")));
            this.productButton7.Location = new System.Drawing.Point(442, 301);
            this.productButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton7.Name = "productButton7";
            this.productButton7.Size = new System.Drawing.Size(165, 116);
            this.productButton7.TabIndex = 40;
            this.productButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton7.UseVisualStyleBackColor = false;
            this.productButton7.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton8
            // 
            this.productButton8.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton8.Image = ((System.Drawing.Image)(resources.GetObject("productButton8.Image")));
            this.productButton8.Location = new System.Drawing.Point(636, 301);
            this.productButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton8.Name = "productButton8";
            this.productButton8.Size = new System.Drawing.Size(165, 116);
            this.productButton8.TabIndex = 39;
            this.productButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton8.UseVisualStyleBackColor = false;
            this.productButton8.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton4
            // 
            this.productButton4.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton4.Image = ((System.Drawing.Image)(resources.GetObject("productButton4.Image")));
            this.productButton4.Location = new System.Drawing.Point(636, 137);
            this.productButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton4.Name = "productButton4";
            this.productButton4.Size = new System.Drawing.Size(165, 116);
            this.productButton4.TabIndex = 38;
            this.productButton4.UseVisualStyleBackColor = false;
            this.productButton4.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton3
            // 
            this.productButton3.BackColor = System.Drawing.Color.Silver;
            this.productButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton3.Image = ((System.Drawing.Image)(resources.GetObject("productButton3.Image")));
            this.productButton3.Location = new System.Drawing.Point(444, 137);
            this.productButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton3.Name = "productButton3";
            this.productButton3.Size = new System.Drawing.Size(165, 116);
            this.productButton3.TabIndex = 37;
            this.productButton3.UseVisualStyleBackColor = false;
            this.productButton3.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton2
            // 
            this.productButton2.BackColor = System.Drawing.Color.LightSalmon;
            this.productButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton2.Image = ((System.Drawing.Image)(resources.GetObject("productButton2.Image")));
            this.productButton2.Location = new System.Drawing.Point(250, 137);
            this.productButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton2.Name = "productButton2";
            this.productButton2.Size = new System.Drawing.Size(165, 116);
            this.productButton2.TabIndex = 36;
            this.productButton2.UseVisualStyleBackColor = false;
            this.productButton2.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton1
            // 
            this.productButton1.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton1.Image = ((System.Drawing.Image)(resources.GetObject("productButton1.Image")));
            this.productButton1.Location = new System.Drawing.Point(57, 137);
            this.productButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton1.Name = "productButton1";
            this.productButton1.Size = new System.Drawing.Size(165, 116);
            this.productButton1.TabIndex = 35;
            this.productButton1.UseVisualStyleBackColor = false;
            this.productButton1.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrderInfo.Location = new System.Drawing.Point(850, 723);
            this.labelOrderInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(83, 28);
            this.labelOrderInfo.TabIndex = 28;
            this.labelOrderInfo.Text = "Total:";
            // 
            // itemLbx
            // 
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.ItemHeight = 16;
            this.itemLbx.Location = new System.Drawing.Point(855, 137);
            this.itemLbx.Margin = new System.Windows.Forms.Padding(4);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(439, 468);
            this.itemLbx.TabIndex = 26;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrder.Location = new System.Drawing.Point(52, 62);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(84, 28);
            this.labelOrder.TabIndex = 25;
            this.labelOrder.Text = "Order";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.numericUpDown1);
            this.startPanel.Controls.Add(this.comboBox1);
            this.startPanel.Controls.Add(this.logsClearBtn);
            this.startPanel.Controls.Add(this.restockBtn);
            this.startPanel.Controls.Add(this.viewStockBtn);
            this.startPanel.Controls.Add(this.viewHistoryBtn);
            this.startPanel.Controls.Add(this.logsInfoLbx);
            this.startPanel.Controls.Add(this.labelMonitor);
            this.startPanel.Controls.Add(this.label4);
            this.startPanel.Controls.Add(this.searchStockLbl);
            this.startPanel.Controls.Add(this.searchLbl);
            this.startPanel.Controls.Add(this.buttonSearch);
            this.startPanel.Controls.Add(this.textBoxResrvID);
            this.startPanel.Controls.Add(this.label2);
            this.startPanel.Controls.Add(this.label3);
            this.startPanel.Controls.Add(this.restockLbl);
            this.startPanel.Controls.Add(this.stockLogsLbl);
            this.startPanel.Location = new System.Drawing.Point(292, 90);
            this.startPanel.Margin = new System.Windows.Forms.Padding(4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1473, 846);
            this.startPanel.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1132, 201);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(973, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // logsClearBtn
            // 
            this.logsClearBtn.Location = new System.Drawing.Point(673, 567);
            this.logsClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logsClearBtn.Name = "logsClearBtn";
            this.logsClearBtn.Size = new System.Drawing.Size(165, 85);
            this.logsClearBtn.TabIndex = 41;
            this.logsClearBtn.Text = "Clear All";
            this.logsClearBtn.UseVisualStyleBackColor = true;
            // 
            // restockBtn
            // 
            this.restockBtn.Location = new System.Drawing.Point(1127, 314);
            this.restockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.restockBtn.Name = "restockBtn";
            this.restockBtn.Size = new System.Drawing.Size(165, 85);
            this.restockBtn.TabIndex = 42;
            this.restockBtn.Text = "Restock";
            this.restockBtn.UseVisualStyleBackColor = true;
            // 
            // viewStockBtn
            // 
            this.viewStockBtn.Location = new System.Drawing.Point(349, 567);
            this.viewStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewStockBtn.Name = "viewStockBtn";
            this.viewStockBtn.Size = new System.Drawing.Size(165, 85);
            this.viewStockBtn.TabIndex = 43;
            this.viewStockBtn.Text = "View Stock";
            this.viewStockBtn.UseVisualStyleBackColor = true;
            // 
            // viewHistoryBtn
            // 
            this.viewHistoryBtn.Location = new System.Drawing.Point(149, 567);
            this.viewHistoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewHistoryBtn.Name = "viewHistoryBtn";
            this.viewHistoryBtn.Size = new System.Drawing.Size(165, 85);
            this.viewHistoryBtn.TabIndex = 44;
            this.viewHistoryBtn.Text = "View Purchase History";
            this.viewHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 16;
            this.logsInfoLbx.Location = new System.Drawing.Point(149, 235);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(688, 292);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(69, 122);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(968, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Select item and amount";
            // 
            // searchStockLbl
            // 
            this.searchStockLbl.AutoSize = true;
            this.searchStockLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStockLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchStockLbl.Location = new System.Drawing.Point(35, 107);
            this.searchStockLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchStockLbl.Name = "searchStockLbl";
            this.searchStockLbl.Size = new System.Drawing.Size(167, 28);
            this.searchStockLbl.TabIndex = 36;
            this.searchStockLbl.Text = "Search Item:";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(35, 107);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(167, 28);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search Item:";
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
            this.buttonSearch.Location = new System.Drawing.Point(517, 105);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(36, 37);
            this.buttonSearch.TabIndex = 35;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxResrvID
            // 
            this.textBoxResrvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResrvID.Location = new System.Drawing.Point(244, 111);
            this.textBoxResrvID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResrvID.Name = "textBoxResrvID";
            this.textBoxResrvID.Size = new System.Drawing.Size(249, 26);
            this.textBoxResrvID.TabIndex = 34;
            this.textBoxResrvID.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(144, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "(error message)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(968, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Restock";
            // 
            // restockLbl
            // 
            this.restockLbl.AutoSize = true;
            this.restockLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockLbl.ForeColor = System.Drawing.Color.DimGray;
            this.restockLbl.Location = new System.Drawing.Point(968, 58);
            this.restockLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restockLbl.Name = "restockLbl";
            this.restockLbl.Size = new System.Drawing.Size(105, 28);
            this.restockLbl.TabIndex = 33;
            this.restockLbl.Text = "Restock";
            // 
            // stockLogsLbl
            // 
            this.stockLogsLbl.AutoSize = true;
            this.stockLogsLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLogsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.stockLogsLbl.Location = new System.Drawing.Point(68, 37);
            this.stockLogsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockLogsLbl.Name = "stockLogsLbl";
            this.stockLogsLbl.Size = new System.Drawing.Size(142, 28);
            this.stockLogsLbl.TabIndex = 33;
            this.stockLogsLbl.Text = "Stock Logs";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(315, 39);
            this.labelShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(197, 33);
            this.labelShopName.TabIndex = 32;
            this.labelShopName.Text = "SHOP NAME";
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
            this.buttonConfirm.Location = new System.Drawing.Point(1088, 633);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(206, 62);
            this.buttonConfirm.TabIndex = 60;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.BackColor = System.Drawing.Color.DimGray;
            this.buttonDecrease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDecrease.FlatAppearance.BorderSize = 0;
            this.buttonDecrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonDecrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrease.ForeColor = System.Drawing.Color.White;
            this.buttonDecrease.Location = new System.Drawing.Point(855, 633);
            this.buttonDecrease.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(94, 62);
            this.buttonDecrease.TabIndex = 59;
            this.buttonDecrease.Text = "-";
            this.buttonDecrease.UseVisualStyleBackColor = false;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.BackColor = System.Drawing.Color.DimGray;
            this.buttonIncrease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIncrease.FlatAppearance.BorderSize = 0;
            this.buttonIncrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonIncrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncrease.ForeColor = System.Drawing.Color.White;
            this.buttonIncrease.Location = new System.Drawing.Point(948, 633);
            this.buttonIncrease.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(94, 62);
            this.buttonIncrease.TabIndex = 61;
            this.buttonIncrease.Text = "+";
            this.buttonIncrease.UseVisualStyleBackColor = false;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button logsClearBtn;
        private System.Windows.Forms.Button restockBtn;
        private System.Windows.Forms.Button viewStockBtn;
        private System.Windows.Forms.Button viewHistoryBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label searchStockLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxResrvID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label restockLbl;
        private System.Windows.Forms.Label stockLogsLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button productButton9;
        private System.Windows.Forms.Button productButton10;
        private System.Windows.Forms.Button productButton11;
        private System.Windows.Forms.Button productButton12;
        private System.Windows.Forms.Button productButton5;
        private System.Windows.Forms.Button productButton6;
        private System.Windows.Forms.Button productButton7;
        private System.Windows.Forms.Button productButton8;
        private System.Windows.Forms.Button productButton4;
        private System.Windows.Forms.Button productButton3;
        private System.Windows.Forms.Button productButton2;
        private System.Windows.Forms.Button productButton1;
        private System.Windows.Forms.Label productLabel9;
        private System.Windows.Forms.Label productLabel10;
        private System.Windows.Forms.Label productLabel11;
        private System.Windows.Forms.Label productLabel12;
        private System.Windows.Forms.Label productLabel5;
        private System.Windows.Forms.Label productLabel6;
        private System.Windows.Forms.Label productLabel8;
        private System.Windows.Forms.Label productLabel7;
        private System.Windows.Forms.Label productLabel4;
        private System.Windows.Forms.Label productLabel3;
        private System.Windows.Forms.Label productLabel1;
        private System.Windows.Forms.Label productLabel2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
    }
}

