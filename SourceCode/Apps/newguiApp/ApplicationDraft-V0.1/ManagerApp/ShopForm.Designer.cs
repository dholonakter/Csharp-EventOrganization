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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.button12 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.logsBtn = new System.Windows.Forms.Button();
            this.stallComboBx = new System.Windows.Forms.ComboBox();
            this.StallLbl = new System.Windows.Forms.Label();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            this.SuspendLayout();
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
            this.button12.Location = new System.Drawing.Point(139, 100);
            this.button12.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(733, 53);
            this.button12.TabIndex = 34;
            this.button12.Text = "    Stall status";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 3000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(898, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 42);
            this.button7.TabIndex = 57;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(948, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 58;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(748, 461);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(124, 69);
            this.refreshBtn.TabIndex = 73;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(607, 461);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(124, 69);
            this.clearBtn.TabIndex = 74;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(279, 461);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(124, 69);
            this.viewAllBtn.TabIndex = 75;
            this.viewAllBtn.Text = "View All Visitors";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            // 
            // logsBtn
            // 
            this.logsBtn.Location = new System.Drawing.Point(139, 461);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(124, 69);
            this.logsBtn.TabIndex = 76;
            this.logsBtn.Text = "View all logs of specified visitor";
            this.logsBtn.UseVisualStyleBackColor = true;
            // 
            // stallComboBx
            // 
            this.stallComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stallComboBx.FormattingEnabled = true;
            this.stallComboBx.Location = new System.Drawing.Point(238, 191);
            this.stallComboBx.Margin = new System.Windows.Forms.Padding(2);
            this.stallComboBx.Name = "stallComboBx";
            this.stallComboBx.Size = new System.Drawing.Size(207, 24);
            this.stallComboBx.TabIndex = 78;
            // 
            // StallLbl
            // 
            this.StallLbl.AutoSize = true;
            this.StallLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StallLbl.Location = new System.Drawing.Point(143, 194);
            this.StallLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StallLbl.Name = "StallLbl";
            this.StallLbl.Size = new System.Drawing.Size(91, 17);
            this.StallLbl.TabIndex = 77;
            this.StallLbl.Text = "Choose Stall:";
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(139, 230);
            this.dataGridViewShop.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.RowTemplate.Height = 24;
            this.dataGridViewShop.Size = new System.Drawing.Size(733, 217);
            this.dataGridViewShop.TabIndex = 79;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.dataGridViewShop);
            this.Controls.Add(this.stallComboBx);
            this.Controls.Add(this.StallLbl);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.logsBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button logsBtn;
        private System.Windows.Forms.ComboBox stallComboBx;
        private System.Windows.Forms.Label StallLbl;
        private System.Windows.Forms.DataGridView dataGridViewShop;
    }
}