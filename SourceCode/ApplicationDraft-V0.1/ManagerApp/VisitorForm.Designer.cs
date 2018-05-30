namespace ManagerApp
{
    partial class VisitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorForm));
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalSpent = new System.Windows.Forms.Label();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            this.labelTotalPresent = new System.Windows.Forms.Label();
            this.labelTotalVisitors = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotalSpent
            // 
            this.labelTotalSpent.AutoSize = true;
            this.labelTotalSpent.ForeColor = System.Drawing.Color.Black;
            this.labelTotalSpent.Location = new System.Drawing.Point(348, 150);
            this.labelTotalSpent.Name = "labelTotalSpent";
            this.labelTotalSpent.Size = new System.Drawing.Size(83, 17);
            this.labelTotalSpent.TabIndex = 47;
            this.labelTotalSpent.Text = "Total spent:";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.ForeColor = System.Drawing.Color.Black;
            this.labelTotalBalance.Location = new System.Drawing.Point(348, 127);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(98, 17);
            this.labelTotalBalance.TabIndex = 46;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewVisitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(62, 173);
            this.dataGridViewVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowTemplate.Height = 24;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(1187, 390);
            this.dataGridViewVisitor.TabIndex = 45;
            // 
            // labelTotalPresent
            // 
            this.labelTotalPresent.AutoSize = true;
            this.labelTotalPresent.ForeColor = System.Drawing.Color.Black;
            this.labelTotalPresent.Location = new System.Drawing.Point(59, 150);
            this.labelTotalPresent.Name = "labelTotalPresent";
            this.labelTotalPresent.Size = new System.Drawing.Size(144, 17);
            this.labelTotalPresent.TabIndex = 44;
            this.labelTotalPresent.Text = "Total visitors present:";
            // 
            // labelTotalVisitors
            // 
            this.labelTotalVisitors.AutoSize = true;
            this.labelTotalVisitors.ForeColor = System.Drawing.Color.Black;
            this.labelTotalVisitors.Location = new System.Drawing.Point(59, 127);
            this.labelTotalVisitors.Name = "labelTotalVisitors";
            this.labelTotalVisitors.Size = new System.Drawing.Size(92, 17);
            this.labelTotalVisitors.TabIndex = 43;
            this.labelTotalVisitors.Text = "Total visitors:";
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
            this.buttonSave.Location = new System.Drawing.Point(62, 53);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(1187, 65);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "    Visitors status";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalSpent);
            this.Controls.Add(this.labelTotalBalance);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.labelTotalPresent);
            this.Controls.Add(this.labelTotalVisitors);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VisitorForm";
            this.Text = "Visitors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalSpent;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
        private System.Windows.Forms.Label labelTotalPresent;
        private System.Windows.Forms.Label labelTotalVisitors;
        private System.Windows.Forms.Button buttonSave;
    }
}