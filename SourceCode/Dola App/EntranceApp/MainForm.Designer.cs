namespace EntranceApp
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblRFIDCode = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnPerform = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxLogMessage = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbrfid = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSelectedAmount = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnLinkCard = new System.Windows.Forms.RadioButton();
            this.rbtnUnLinkCard = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCardLinkedStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timerResetControls = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(22, 126);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(85, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(153, 125);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(85, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.lblRFIDCode);
            this.groupBox1.Controls.Add(this.lblEmailAddress);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheckIn/Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "RFIDCode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FullName:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(150, 179);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(88, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "...........................";
            // 
            // lblRFIDCode
            // 
            this.lblRFIDCode.AutoSize = true;
            this.lblRFIDCode.Location = new System.Drawing.Point(152, 82);
            this.lblRFIDCode.Name = "lblRFIDCode";
            this.lblRFIDCode.Size = new System.Drawing.Size(88, 13);
            this.lblRFIDCode.TabIndex = 2;
            this.lblRFIDCode.Text = "...........................";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(150, 56);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(88, 13);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "...........................";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(150, 25);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "...........................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message:";
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(116, 146);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(117, 23);
            this.btnClearLogs.TabIndex = 7;
            this.btnClearLogs.Text = "ClearLogs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 20);
            this.tbName.TabIndex = 9;
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(48, 43);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(90, 23);
            this.btnPerform.TabIndex = 10;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.WhenPerformButtonIsClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "FullName:";
            // 
            // lbxLogMessage
            // 
            this.lbxLogMessage.FormattingEnabled = true;
            this.lbxLogMessage.Location = new System.Drawing.Point(6, 17);
            this.lbxLogMessage.Name = "lbxLogMessage";
            this.lbxLogMessage.Size = new System.Drawing.Size(323, 121);
            this.lbxLogMessage.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "RFIDCode:";
            // 
            // tbrfid
            // 
            this.tbrfid.Enabled = false;
            this.tbrfid.Location = new System.Drawing.Point(103, 125);
            this.tbrfid.Name = "tbrfid";
            this.tbrfid.Size = new System.Drawing.Size(205, 20);
            this.tbrfid.TabIndex = 16;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(103, 44);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(205, 20);
            this.tbEmailAddress.TabIndex = 18;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(103, 71);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(205, 20);
            this.tbPhoneNumber.TabIndex = 19;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Phone:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSelectedAmount);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.lblCardLinkedStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPhoneNumber);
            this.groupBox2.Controls.Add(this.tbrfid);
            this.groupBox2.Controls.Add(this.tbEmailAddress);
            this.groupBox2.Location = new System.Drawing.Point(394, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 259);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buy Tickets";
            // 
            // cbxSelectedAmount
            // 
            this.cbxSelectedAmount.FormattingEnabled = true;
            this.cbxSelectedAmount.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "50"});
            this.cbxSelectedAmount.Location = new System.Drawing.Point(103, 96);
            this.cbxSelectedAmount.Name = "cbxSelectedAmount";
            this.cbxSelectedAmount.Size = new System.Drawing.Size(205, 21);
            this.cbxSelectedAmount.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnLinkCard);
            this.groupBox4.Controls.Add(this.rbtnUnLinkCard);
            this.groupBox4.Controls.Add(this.btnPerform);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Location = new System.Drawing.Point(28, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 82);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions:";
            // 
            // rbtnLinkCard
            // 
            this.rbtnLinkCard.AutoSize = true;
            this.rbtnLinkCard.Location = new System.Drawing.Point(72, 15);
            this.rbtnLinkCard.Name = "rbtnLinkCard";
            this.rbtnLinkCard.Size = new System.Drawing.Size(67, 17);
            this.rbtnLinkCard.TabIndex = 22;
            this.rbtnLinkCard.TabStop = true;
            this.rbtnLinkCard.Text = "LinkCard";
            this.rbtnLinkCard.UseVisualStyleBackColor = true;
            // 
            // rbtnUnLinkCard
            // 
            this.rbtnUnLinkCard.AutoSize = true;
            this.rbtnUnLinkCard.Location = new System.Drawing.Point(153, 15);
            this.rbtnUnLinkCard.Name = "rbtnUnLinkCard";
            this.rbtnUnLinkCard.Size = new System.Drawing.Size(81, 17);
            this.rbtnUnLinkCard.TabIndex = 22;
            this.rbtnUnLinkCard.TabStop = true;
            this.rbtnUnLinkCard.Text = "UnLinkCard";
            this.rbtnUnLinkCard.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCardLinkedStatus
            // 
            this.lblCardLinkedStatus.AutoSize = true;
            this.lblCardLinkedStatus.Location = new System.Drawing.Point(102, 155);
            this.lblCardLinkedStatus.Name = "lblCardLinkedStatus";
            this.lblCardLinkedStatus.Size = new System.Drawing.Size(88, 13);
            this.lblCardLinkedStatus.TabIndex = 2;
            this.lblCardLinkedStatus.Text = "...........................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TopUp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "LinkStatus:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxLogMessage);
            this.groupBox3.Controls.Add(this.btnClearLogs);
            this.groupBox3.Location = new System.Drawing.Point(225, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 180);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LogMessage";
            // 
            // timerResetControls
            // 
            this.timerResetControls.Interval = 1000;
            this.timerResetControls.Tick += new System.EventHandler(this.TimerToResetControls_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrance App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxLogMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbrfid;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRFIDCode;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtnUnLinkCard;
        private System.Windows.Forms.RadioButton rbtnLinkCard;
        private System.Windows.Forms.Label lblCardLinkedStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timerResetControls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSelectedAmount;
    }
}

