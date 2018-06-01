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
            this.overviewBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startPanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.labelVisitor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.overviewBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 945);
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
            this.overviewBtn.Location = new System.Drawing.Point(15, 110);
            this.overviewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(207, 66);
            this.overviewBtn.TabIndex = 18;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
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
            this.productBtn.Location = new System.Drawing.Point(15, 223);
            this.productBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(207, 66);
            this.productBtn.TabIndex = 20;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            // startPanel
            // 
            this.startPanel.Location = new System.Drawing.Point(293, 90);
            this.startPanel.Margin = new System.Windows.Forms.Padding(4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1473, 846);
            this.startPanel.TabIndex = 10;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.button2);
            this.productPanel.Controls.Add(this.labelOrderInfo);
            this.productPanel.Controls.Add(this.labelVisitor);
            this.productPanel.Location = new System.Drawing.Point(297, 90);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1329, 780);
            this.productPanel.TabIndex = 11;
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrderInfo.Location = new System.Drawing.Point(616, 92);
            this.labelOrderInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(84, 28);
            this.labelOrderInfo.TabIndex = 27;
            this.labelOrderInfo.Text = "Order";
            // 
            // labelVisitor
            // 
            this.labelVisitor.AutoSize = true;
            this.labelVisitor.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitor.Location = new System.Drawing.Point(72, 92);
            this.labelVisitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisitor.Name = "labelVisitor";
            this.labelVisitor.Size = new System.Drawing.Size(95, 28);
            this.labelVisitor.TabIndex = 26;
            this.labelVisitor.Text = "Visitor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 55);
            this.button2.TabIndex = 29;
            this.button2.Text = "stop scanning items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1821, 945);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label labelVisitor;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Button button2;
    }
}

