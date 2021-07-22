namespace OOPIssueTracker
{
    partial class resolvedViewIssue
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
            this.resolvedName = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.idnumber = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.severity = new System.Windows.Forms.TextBox();
            this.reportDate = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.TextBox();
            this.reportURLBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openURL = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resolveDate = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.issueStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resolvedName
            // 
            this.resolvedName.AutoSize = true;
            this.resolvedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolvedName.Location = new System.Drawing.Point(38, 9);
            this.resolvedName.Name = "resolvedName";
            this.resolvedName.Size = new System.Drawing.Size(82, 17);
            this.resolvedName.TabIndex = 0;
            this.resolvedName.Text = "Issue Name";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(349, 9);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(77, 17);
            this.type.TabIndex = 1;
            this.type.Text = "Issue Type";
            // 
            // idnumber
            // 
            this.idnumber.Location = new System.Drawing.Point(352, 398);
            this.idnumber.Name = "idnumber";
            this.idnumber.ReadOnly = true;
            this.idnumber.Size = new System.Drawing.Size(146, 20);
            this.idnumber.TabIndex = 2;
            this.idnumber.TextChanged += new System.EventHandler(this.idnumber_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(320, 472);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID#";
            // 
            // severity
            // 
            this.severity.Location = new System.Drawing.Point(111, 71);
            this.severity.Name = "severity";
            this.severity.ReadOnly = true;
            this.severity.Size = new System.Drawing.Size(146, 20);
            this.severity.TabIndex = 5;
            // 
            // reportDate
            // 
            this.reportDate.Location = new System.Drawing.Point(111, 114);
            this.reportDate.Name = "reportDate";
            this.reportDate.ReadOnly = true;
            this.reportDate.Size = new System.Drawing.Size(146, 20);
            this.reportDate.TabIndex = 6;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(111, 151);
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Size = new System.Drawing.Size(146, 20);
            this.version.TabIndex = 7;
            this.version.UseWaitCursor = true;
            // 
            // reportURLBox
            // 
            this.reportURLBox.Location = new System.Drawing.Point(111, 195);
            this.reportURLBox.Name = "reportURLBox";
            this.reportURLBox.ReadOnly = true;
            this.reportURLBox.Size = new System.Drawing.Size(146, 20);
            this.reportURLBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Issue Severity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Issue Report Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Game Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ticket URL";
            // 
            // openURL
            // 
            this.openURL.Location = new System.Drawing.Point(145, 221);
            this.openURL.Name = "openURL";
            this.openURL.Size = new System.Drawing.Size(75, 23);
            this.openURL.TabIndex = 13;
            this.openURL.Text = "Open URL";
            this.openURL.UseVisualStyleBackColor = true;
            this.openURL.Click += new System.EventHandler(this.openURL_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(111, 265);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.ReadOnly = true;
            this.detailsBox.Size = new System.Drawing.Size(146, 194);
            this.detailsBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Issue Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Resolved On";
            // 
            // resolveDate
            // 
            this.resolveDate.Location = new System.Drawing.Point(352, 68);
            this.resolveDate.Name = "resolveDate";
            this.resolveDate.ReadOnly = true;
            this.resolveDate.Size = new System.Drawing.Size(146, 20);
            this.resolveDate.TabIndex = 17;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(352, 188);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(146, 160);
            this.notes.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Issue Notes";
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(423, 354);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(75, 23);
            this.addNote.TabIndex = 20;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(423, 472);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Issue Status";
            // 
            // issueStatus
            // 
            this.issueStatus.Location = new System.Drawing.Point(352, 118);
            this.issueStatus.Name = "issueStatus";
            this.issueStatus.ReadOnly = true;
            this.issueStatus.Size = new System.Drawing.Size(146, 20);
            this.issueStatus.TabIndex = 23;
            // 
            // resolvedViewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 507);
            this.Controls.Add(this.issueStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.resolveDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.openURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportURLBox);
            this.Controls.Add(this.version);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.severity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.idnumber);
            this.Controls.Add(this.type);
            this.Controls.Add(this.resolvedName);
            this.Name = "resolvedViewIssue";
            this.Text = "[Resolved] View Issue Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resolvedName;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox idnumber;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox severity;
        private System.Windows.Forms.TextBox reportDate;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.TextBox reportURLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openURL;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resolveDate;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox issueStatus;
    }
}