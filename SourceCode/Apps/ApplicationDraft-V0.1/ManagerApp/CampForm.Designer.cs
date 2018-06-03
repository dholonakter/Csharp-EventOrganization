namespace ManagerApp
{
    partial class CampForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampForm));
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonAvailable = new System.Windows.Forms.Button();
            this.buttonBooked = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridViewCamp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(130)))));
            this.buttonClean.FlatAppearance.BorderSize = 0;
            this.buttonClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(34)))));
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(122)))), ((int)(((byte)(17)))));
            this.buttonClean.Image = ((System.Drawing.Image)(resources.GetObject("buttonClean.Image")));
            this.buttonClean.Location = new System.Drawing.Point(173, 497);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(191, 44);
            this.buttonClean.TabIndex = 40;
            this.buttonClean.Text = "     Spots to clean";
            this.buttonClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonAvailable
            // 
            this.buttonAvailable.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAvailable.FlatAppearance.BorderSize = 0;
            this.buttonAvailable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAvailable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(232)))), ((int)(((byte)(99)))));
            this.buttonAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvailable.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAvailable.Image = ((System.Drawing.Image)(resources.GetObject("buttonAvailable.Image")));
            this.buttonAvailable.Location = new System.Drawing.Point(384, 497);
            this.buttonAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAvailable.Name = "buttonAvailable";
            this.buttonAvailable.Size = new System.Drawing.Size(191, 44);
            this.buttonAvailable.TabIndex = 39;
            this.buttonAvailable.Text = "    Available spots";
            this.buttonAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAvailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAvailable.UseVisualStyleBackColor = false;
            this.buttonAvailable.Click += new System.EventHandler(this.buttonAvailable_Click);
            // 
            // buttonBooked
            // 
            this.buttonBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(68)))));
            this.buttonBooked.FlatAppearance.BorderSize = 0;
            this.buttonBooked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBooked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.buttonBooked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooked.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooked.ForeColor = System.Drawing.Color.Black;
            this.buttonBooked.Image = ((System.Drawing.Image)(resources.GetObject("buttonBooked.Image")));
            this.buttonBooked.Location = new System.Drawing.Point(596, 497);
            this.buttonBooked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBooked.Name = "buttonBooked";
            this.buttonBooked.Size = new System.Drawing.Size(191, 44);
            this.buttonBooked.TabIndex = 36;
            this.buttonBooked.Text = "       Booked spots";
            this.buttonBooked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBooked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBooked.UseVisualStyleBackColor = false;
            this.buttonBooked.Click += new System.EventHandler(this.buttonBooked_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.button9.ForeColor = System.Drawing.Color.DarkGreen;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(173, 140);
            this.button9.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(965, 65);
            this.button9.TabIndex = 35;
            this.button9.Text = "    Camps status";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCamp
            // 
            this.dataGridViewCamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamp.Location = new System.Drawing.Point(173, 225);
            this.dataGridViewCamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCamp.Name = "dataGridViewCamp";
            this.dataGridViewCamp.RowTemplate.Height = 24;
            this.dataGridViewCamp.Size = new System.Drawing.Size(965, 247);
            this.dataGridViewCamp.TabIndex = 42;
            this.dataGridViewCamp.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewCamp_CellBeginEdit);
            this.dataGridViewCamp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCamp_CellEndEdit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1061, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 44);
            this.button1.TabIndex = 49;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(196)))), ((int)(((byte)(251)))));
            this.buttonAll.FlatAppearance.BorderSize = 0;
            this.buttonAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonAll.Image")));
            this.buttonAll.Location = new System.Drawing.Point(821, 496);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(191, 44);
            this.buttonAll.TabIndex = 50;
            this.buttonAll.Text = "      Show all camps";
            this.buttonAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
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
            this.button7.Location = new System.Drawing.Point(1197, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 52);
            this.button7.TabIndex = 51;
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
            this.homeBtn.Location = new System.Drawing.Point(1264, 15);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 52);
            this.homeBtn.TabIndex = 52;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // CampForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 703);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCamp);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonAvailable);
            this.Controls.Add(this.buttonBooked);
            this.Controls.Add(this.button9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CampForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonAvailable;
        private System.Windows.Forms.Button buttonBooked;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridViewCamp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button homeBtn;
    }
}