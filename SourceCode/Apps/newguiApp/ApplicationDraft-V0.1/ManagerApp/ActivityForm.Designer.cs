namespace ManagerApp
{
    partial class ActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.scheduleLbx = new System.Windows.Forms.ListBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activityLbx = new System.Windows.Forms.ListBox();
            this.button12 = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleLbx
            // 
            this.scheduleLbx.FormattingEnabled = true;
            this.scheduleLbx.Location = new System.Drawing.Point(52, 194);
            this.scheduleLbx.Name = "scheduleLbx";
            this.scheduleLbx.Size = new System.Drawing.Size(441, 277);
            this.scheduleLbx.TabIndex = 69;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(48, 138);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(203, 23);
            this.searchLbl.TabIndex = 68;
            this.searchLbl.Text = "Schedule of Events:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(549, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Activity Statuses:";
            // 
            // activityLbx
            // 
            this.activityLbx.FormattingEnabled = true;
            this.activityLbx.Location = new System.Drawing.Point(553, 194);
            this.activityLbx.Name = "activityLbx";
            this.activityLbx.Size = new System.Drawing.Size(441, 277);
            this.activityLbx.TabIndex = 69;
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
            this.button12.Location = new System.Drawing.Point(148, 43);
            this.button12.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(733, 53);
            this.button12.TabIndex = 70;
            this.button12.Text = "Activity Status";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(456, 512);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(124, 69);
            this.refreshBtn.TabIndex = 74;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 605);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.activityLbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleLbx);
            this.Controls.Add(this.searchLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActivityForm";
            this.Text = "ActivityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scheduleLbx;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox activityLbx;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button refreshBtn;
    }
}