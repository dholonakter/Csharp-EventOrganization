namespace ManagerApp
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
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonTop5 = new System.Windows.Forms.Button();
            this.buttonAllStands = new System.Windows.Forms.Button();
            this.buttonAllStores = new System.Windows.Forms.Button();
            this.buttonAllShops = new System.Windows.Forms.Button();
            this.buttonMostPurchased = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(121, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Total money earned:";
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(124, 149);
            this.dataGridViewShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.RowTemplate.Height = 24;
            this.dataGridViewShop.Size = new System.Drawing.Size(673, 357);
            this.dataGridViewShop.TabIndex = 37;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.button12.ForeColor = System.Drawing.Color.DarkGreen;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(120, 40);
            this.button12.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(977, 65);
            this.button12.TabIndex = 34;
            this.button12.Text = "    Shops status";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(180, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 34);
            this.label18.TabIndex = 40;
            this.label18.Text = "Section to import data\r\n\r\n";
            // 
            // buttonTop5
            // 
            this.buttonTop5.Location = new System.Drawing.Point(841, 148);
            this.buttonTop5.Name = "buttonTop5";
            this.buttonTop5.Size = new System.Drawing.Size(157, 43);
            this.buttonTop5.TabIndex = 51;
            this.buttonTop5.Text = "Show top 5 shops";
            this.buttonTop5.UseVisualStyleBackColor = true;
            this.buttonTop5.Click += new System.EventHandler(this.buttonTop5_Click);
            // 
            // buttonAllStands
            // 
            this.buttonAllStands.Location = new System.Drawing.Point(841, 200);
            this.buttonAllStands.Name = "buttonAllStands";
            this.buttonAllStands.Size = new System.Drawing.Size(157, 43);
            this.buttonAllStands.TabIndex = 52;
            this.buttonAllStands.Text = "Show all loan stands";
            this.buttonAllStands.UseVisualStyleBackColor = true;
            this.buttonAllStands.Click += new System.EventHandler(this.buttonAllStands_Click);
            // 
            // buttonAllStores
            // 
            this.buttonAllStores.Location = new System.Drawing.Point(841, 249);
            this.buttonAllStores.Name = "buttonAllStores";
            this.buttonAllStores.Size = new System.Drawing.Size(157, 43);
            this.buttonAllStores.TabIndex = 53;
            this.buttonAllStores.Text = "Show all stores";
            this.buttonAllStores.UseVisualStyleBackColor = true;
            this.buttonAllStores.Click += new System.EventHandler(this.buttonAllStores_Click);
            // 
            // buttonAllShops
            // 
            this.buttonAllShops.Location = new System.Drawing.Point(841, 298);
            this.buttonAllShops.Name = "buttonAllShops";
            this.buttonAllShops.Size = new System.Drawing.Size(157, 43);
            this.buttonAllShops.TabIndex = 54;
            this.buttonAllShops.Text = "Show all shops";
            this.buttonAllShops.UseVisualStyleBackColor = true;
            this.buttonAllShops.Click += new System.EventHandler(this.buttonAllShops_Click);
            // 
            // buttonMostPurchased
            // 
            this.buttonMostPurchased.Location = new System.Drawing.Point(841, 347);
            this.buttonMostPurchased.Name = "buttonMostPurchased";
            this.buttonMostPurchased.Size = new System.Drawing.Size(157, 43);
            this.buttonMostPurchased.TabIndex = 55;
            this.buttonMostPurchased.Text = "Most purchased items";
            this.buttonMostPurchased.UseVisualStyleBackColor = true;
            this.buttonMostPurchased.Click += new System.EventHandler(this.buttonMostPurchased_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(841, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 43);
            this.buttonSave.TabIndex = 56;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 587);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAllShops);
            this.Controls.Add(this.buttonMostPurchased);
            this.Controls.Add(this.buttonAllStores);
            this.Controls.Add(this.buttonAllStands);
            this.Controls.Add(this.buttonTop5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewShop);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label18);
            this.Name = "ShopForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonTop5;
        private System.Windows.Forms.Button buttonAllStands;
        private System.Windows.Forms.Button buttonAllStores;
        private System.Windows.Forms.Button buttonAllShops;
        private System.Windows.Forms.Button buttonMostPurchased;
        private System.Windows.Forms.Button buttonSave;
    }
}