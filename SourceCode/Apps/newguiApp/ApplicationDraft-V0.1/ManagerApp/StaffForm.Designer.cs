namespace ManagerApp
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationComboBx = new System.Windows.Forms.ComboBox();
            this.logsClearBtn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.logsBtn = new System.Windows.Forms.Button();
            this.staffLbx = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.locationLbl.Location = new System.Drawing.Point(159, 162);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(118, 17);
            this.locationLbl.TabIndex = 1;
            this.locationLbl.Text = "Choose Location:";
            // 
            // locationComboBx
            // 
            this.locationComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.locationComboBx.FormattingEnabled = true;
            this.locationComboBx.Location = new System.Drawing.Point(281, 159);
            this.locationComboBx.Margin = new System.Windows.Forms.Padding(2);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(207, 24);
            this.locationComboBx.TabIndex = 2;
            // 
            // logsClearBtn
            // 
            this.logsClearBtn.Location = new System.Drawing.Point(536, 455);
            this.logsClearBtn.Name = "logsClearBtn";
            this.logsClearBtn.Size = new System.Drawing.Size(124, 69);
            this.logsClearBtn.TabIndex = 59;
            this.logsClearBtn.Text = "Clear All";
            this.logsClearBtn.UseVisualStyleBackColor = true;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Location = new System.Drawing.Point(300, 455);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(124, 69);
            this.viewAllBtn.TabIndex = 60;
            this.viewAllBtn.Text = "View All Staff Members";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            // 
            // logsBtn
            // 
            this.logsBtn.Location = new System.Drawing.Point(160, 455);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(124, 69);
            this.logsBtn.TabIndex = 61;
            this.logsBtn.Text = "View Logs of specified staff member";
            this.logsBtn.UseVisualStyleBackColor = true;
            // 
            // staffLbx
            // 
            this.staffLbx.FormattingEnabled = true;
            this.staffLbx.Location = new System.Drawing.Point(160, 203);
            this.staffLbx.Name = "staffLbx";
            this.staffLbx.Size = new System.Drawing.Size(658, 238);
            this.staffLbx.TabIndex = 58;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(48, 53);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(890, 53);
            this.buttonSave.TabIndex = 62;
            this.buttonSave.Text = "    Staff Status";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(694, 455);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(124, 69);
            this.refreshBtn.TabIndex = 69;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 571);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.logsClearBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.logsBtn);
            this.Controls.Add(this.staffLbx);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.locationLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox locationComboBx;
        private System.Windows.Forms.Button logsClearBtn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button logsBtn;
        private System.Windows.Forms.ListBox staffLbx;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button refreshBtn;
    }
}