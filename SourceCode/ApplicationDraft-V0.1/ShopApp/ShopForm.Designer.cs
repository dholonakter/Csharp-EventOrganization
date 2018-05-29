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
            this.overviewBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.addcartBtn = new System.Windows.Forms.Button();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkRbtn = new System.Windows.Forms.RadioButton();
            this.foodRbtn = new System.Windows.Forms.RadioButton();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.quantitySelec = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.overviewBtn);
            this.panel1.Controls.Add(this.cartBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 768);
            this.panel1.TabIndex = 0;
            // 
            // overviewBtn
            // 
            this.overviewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overviewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.overviewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.overviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBtn.ForeColor = System.Drawing.Color.White;
            this.overviewBtn.Image = ((System.Drawing.Image)(resources.GetObject("overviewBtn.Image")));
            this.overviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overviewBtn.Location = new System.Drawing.Point(11, 89);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(155, 54);
            this.overviewBtn.TabIndex = 15;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Image = ((System.Drawing.Image)(resources.GetObject("cartBtn.Image")));
            this.cartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartBtn.Location = new System.Drawing.Point(11, 271);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(155, 54);
            this.cartBtn.TabIndex = 16;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
            // 
            // productBtn
            // 
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(11, 181);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(155, 54);
            this.productBtn.TabIndex = 17;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            // productPanel
            // 
            this.productPanel.Controls.Add(this.button2);
            this.productPanel.Controls.Add(this.label4);
            this.productPanel.Controls.Add(this.addcartBtn);
            this.productPanel.Controls.Add(this.itemLbx);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.drinkRbtn);
            this.productPanel.Controls.Add(this.foodRbtn);
            this.productPanel.Controls.Add(this.subtotalLbl);
            this.productPanel.Controls.Add(this.quantitySelec);
            this.productPanel.Location = new System.Drawing.Point(230, 70);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(997, 634);
            this.productPanel.TabIndex = 4;
            // 
            // addcartBtn
            // 
            this.addcartBtn.BackColor = System.Drawing.Color.DimGray;
            this.addcartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addcartBtn.FlatAppearance.BorderSize = 0;
            this.addcartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addcartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addcartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcartBtn.ForeColor = System.Drawing.Color.White;
            this.addcartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcartBtn.Location = new System.Drawing.Point(405, 504);
            this.addcartBtn.Name = "addcartBtn";
            this.addcartBtn.Size = new System.Drawing.Size(227, 40);
            this.addcartBtn.TabIndex = 27;
            this.addcartBtn.Text = "Add To Cart";
            this.addcartBtn.UseVisualStyleBackColor = false;
            this.addcartBtn.Click += new System.EventHandler(this.addcartBtn_Click);
            // 
            // itemLbx
            // 
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.Location = new System.Drawing.Point(104, 162);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(384, 316);
            this.itemLbx.TabIndex = 26;
            this.itemLbx.SelectedIndexChanged += new System.EventHandler(this.itemLbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(534, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(100, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose Type :";
            // 
            // drinkRbtn
            // 
            this.drinkRbtn.AutoSize = true;
            this.drinkRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkRbtn.Location = new System.Drawing.Point(380, 84);
            this.drinkRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.drinkRbtn.Name = "drinkRbtn";
            this.drinkRbtn.Size = new System.Drawing.Size(57, 20);
            this.drinkRbtn.TabIndex = 24;
            this.drinkRbtn.TabStop = true;
            this.drinkRbtn.Text = "Drink";
            this.drinkRbtn.UseVisualStyleBackColor = true;
            this.drinkRbtn.CheckedChanged += new System.EventHandler(this.drinkRbtn_CheckedChanged);
            // 
            // foodRbtn
            // 
            this.foodRbtn.AutoSize = true;
            this.foodRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodRbtn.Location = new System.Drawing.Point(286, 83);
            this.foodRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foodRbtn.Name = "foodRbtn";
            this.foodRbtn.Size = new System.Drawing.Size(58, 20);
            this.foodRbtn.TabIndex = 23;
            this.foodRbtn.TabStop = true;
            this.foodRbtn.Text = "Food";
            this.foodRbtn.UseVisualStyleBackColor = true;
            this.foodRbtn.CheckedChanged += new System.EventHandler(this.foodRbtn_CheckedChanged);
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtotalLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.subtotalLbl.ForeColor = System.Drawing.Color.DimGray;
            this.subtotalLbl.Location = new System.Drawing.Point(104, 511);
            this.subtotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Padding = new System.Windows.Forms.Padding(22, 8, 22, 8);
            this.subtotalLbl.Size = new System.Drawing.Size(212, 41);
            this.subtotalLbl.TabIndex = 21;
            this.subtotalLbl.Text = "Subtotal: 0.00 €";
            // 
            // quantitySelec
            // 
            this.quantitySelec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitySelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelec.Location = new System.Drawing.Point(649, 82);
            this.quantitySelec.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySelec.Name = "quantitySelec";
            this.quantitySelec.Size = new System.Drawing.Size(92, 22);
            this.quantitySelec.TabIndex = 19;
            this.quantitySelec.ValueChanged += new System.EventHandler(this.quantitySelec_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(547, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantity :";
            // 
            // startPanel
            // 
            this.startPanel.Location = new System.Drawing.Point(219, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1105, 687);
            this.startPanel.TabIndex = 9;
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
            this.button2.Location = new System.Drawing.Point(683, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "  Confirm Payment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.RadioButton drinkRbtn;
        private System.Windows.Forms.RadioButton foodRbtn;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.NumericUpDown quantitySelec;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addcartBtn;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

