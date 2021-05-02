namespace OOPIssueTracker
{
    partial class newIssueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.issueType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.severitySelect = new System.Windows.Forms.GroupBox();
            this.sevUrgent = new System.Windows.Forms.RadioButton();
            this.sevHigh = new System.Windows.Forms.RadioButton();
            this.sevMedium = new System.Windows.Forms.RadioButton();
            this.sevLow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.issueName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.detailText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openIssues = new System.Windows.Forms.Button();
            this.issueDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.viewResolved = new System.Windows.Forms.Button();
            this.severitySelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Submit New Issue";
            // 
            // issueType
            // 
            this.issueType.FormattingEnabled = true;
            this.issueType.Items.AddRange(new object[] {
            "Game / Missing File",
            "Game / Missing Animation",
            "Game / Missing Texture",
            "Game / Map Crash",
            "Game / Collision Issue",
            "Forum / Code Error",
            "Forum / Page Issue",
            "Forum / Broken Links"});
            this.issueType.Location = new System.Drawing.Point(116, 75);
            this.issueType.Name = "issueType";
            this.issueType.Size = new System.Drawing.Size(146, 108);
            this.issueType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issue Type";
            // 
            // severitySelect
            // 
            this.severitySelect.Controls.Add(this.sevUrgent);
            this.severitySelect.Controls.Add(this.sevHigh);
            this.severitySelect.Controls.Add(this.sevMedium);
            this.severitySelect.Controls.Add(this.sevLow);
            this.severitySelect.Location = new System.Drawing.Point(116, 189);
            this.severitySelect.Name = "severitySelect";
            this.severitySelect.Size = new System.Drawing.Size(146, 113);
            this.severitySelect.TabIndex = 4;
            this.severitySelect.TabStop = false;
            this.severitySelect.Text = "Severity";
            // 
            // sevUrgent
            // 
            this.sevUrgent.AutoSize = true;
            this.sevUrgent.Location = new System.Drawing.Point(7, 90);
            this.sevUrgent.Name = "sevUrgent";
            this.sevUrgent.Size = new System.Drawing.Size(57, 17);
            this.sevUrgent.TabIndex = 3;
            this.sevUrgent.TabStop = true;
            this.sevUrgent.Text = "Urgent";
            this.sevUrgent.UseVisualStyleBackColor = true;
            // 
            // sevHigh
            // 
            this.sevHigh.AutoSize = true;
            this.sevHigh.Location = new System.Drawing.Point(7, 67);
            this.sevHigh.Name = "sevHigh";
            this.sevHigh.Size = new System.Drawing.Size(47, 17);
            this.sevHigh.TabIndex = 2;
            this.sevHigh.TabStop = true;
            this.sevHigh.Text = "High";
            this.sevHigh.UseVisualStyleBackColor = true;
            // 
            // sevMedium
            // 
            this.sevMedium.AutoSize = true;
            this.sevMedium.Location = new System.Drawing.Point(7, 43);
            this.sevMedium.Name = "sevMedium";
            this.sevMedium.Size = new System.Drawing.Size(62, 17);
            this.sevMedium.TabIndex = 1;
            this.sevMedium.TabStop = true;
            this.sevMedium.Text = "Medium";
            this.sevMedium.UseVisualStyleBackColor = true;
            // 
            // sevLow
            // 
            this.sevLow.AutoSize = true;
            this.sevLow.Location = new System.Drawing.Point(7, 20);
            this.sevLow.Name = "sevLow";
            this.sevLow.Size = new System.Drawing.Size(45, 17);
            this.sevLow.TabIndex = 0;
            this.sevLow.TabStop = true;
            this.sevLow.Text = "Low";
            this.sevLow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Issue Severity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Issue Name";
            // 
            // issueName
            // 
            this.issueName.Location = new System.Drawing.Point(116, 325);
            this.issueName.Multiline = true;
            this.issueName.Name = "issueName";
            this.issueName.Size = new System.Drawing.Size(146, 28);
            this.issueName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Submit a new issue report for our developers to look into.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Game Version";
            // 
            // gameVersion
            // 
            this.gameVersion.Location = new System.Drawing.Point(432, 75);
            this.gameVersion.Name = "gameVersion";
            this.gameVersion.Size = new System.Drawing.Size(227, 20);
            this.gameVersion.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ticket Report Link";
            // 
            // reportLink
            // 
            this.reportLink.Location = new System.Drawing.Point(432, 123);
            this.reportLink.Name = "reportLink";
            this.reportLink.Size = new System.Drawing.Size(227, 20);
            this.reportLink.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Issue Details";
            // 
            // detailText
            // 
            this.detailText.Location = new System.Drawing.Point(432, 162);
            this.detailText.MaxLength = 8000;
            this.detailText.Multiline = true;
            this.detailText.Name = "detailText";
            this.detailText.Size = new System.Drawing.Size(227, 140);
            this.detailText.TabIndex = 14;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(614, 325);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 21);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(533, 325);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openIssues
            // 
            this.openIssues.Location = new System.Drawing.Point(418, 325);
            this.openIssues.Name = "openIssues";
            this.openIssues.Size = new System.Drawing.Size(109, 21);
            this.openIssues.TabIndex = 17;
            this.openIssues.Text = "View Open Issues";
            this.openIssues.UseVisualStyleBackColor = true;
            this.openIssues.Click += new System.EventHandler(this.openIssues_Click);
            // 
            // issueDate
            // 
            this.issueDate.Location = new System.Drawing.Point(432, 37);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(227, 20);
            this.issueDate.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Submission Date";
            // 
            // viewResolved
            // 
            this.viewResolved.Location = new System.Drawing.Point(305, 325);
            this.viewResolved.Name = "viewResolved";
            this.viewResolved.Size = new System.Drawing.Size(109, 21);
            this.viewResolved.TabIndex = 20;
            this.viewResolved.Text = "View Resolved Issues";
            this.viewResolved.UseVisualStyleBackColor = true;
            this.viewResolved.Click += new System.EventHandler(this.viewResolved_Click);
            // 
            // newIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 366);
            this.Controls.Add(this.viewResolved);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.openIssues);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.detailText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reportLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gameVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.issueName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.severitySelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.issueType);
            this.Controls.Add(this.label1);
            this.Name = "newIssueForm";
            this.Text = "Submit a New Issue";
            this.Load += new System.EventHandler(this.newIssueForm_Load);
            this.severitySelect.ResumeLayout(false);
            this.severitySelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox issueType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox severitySelect;
        private System.Windows.Forms.RadioButton sevUrgent;
        private System.Windows.Forms.RadioButton sevHigh;
        private System.Windows.Forms.RadioButton sevMedium;
        private System.Windows.Forms.RadioButton sevLow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox issueName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gameVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reportLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox detailText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button openIssues;
        private System.Windows.Forms.DateTimePicker issueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button viewResolved;
    }
}