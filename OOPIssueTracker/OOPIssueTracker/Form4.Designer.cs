namespace OOPIssueTracker
{
    partial class resolvedIssues
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
            this.issueDetails = new System.Windows.Forms.Button();
            this.openIssueAgain = new System.Windows.Forms.Button();
            this.newIssue = new System.Windows.Forms.Button();
            this.openIssues = new System.Windows.Forms.Button();
            this.completedIssue = new System.Windows.Forms.ListBox();
            this.resolvedCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loadIssueData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issueDetails
            // 
            this.issueDetails.Location = new System.Drawing.Point(332, 12);
            this.issueDetails.Name = "issueDetails";
            this.issueDetails.Size = new System.Drawing.Size(154, 40);
            this.issueDetails.TabIndex = 0;
            this.issueDetails.Text = "View Issue Details";
            this.issueDetails.UseVisualStyleBackColor = true;
            this.issueDetails.Click += new System.EventHandler(this.issueDetails_Click);
            // 
            // openIssueAgain
            // 
            this.openIssueAgain.Location = new System.Drawing.Point(332, 58);
            this.openIssueAgain.Name = "openIssueAgain";
            this.openIssueAgain.Size = new System.Drawing.Size(154, 40);
            this.openIssueAgain.TabIndex = 1;
            this.openIssueAgain.Text = "Re-Open Issue";
            this.openIssueAgain.UseVisualStyleBackColor = true;
            this.openIssueAgain.Click += new System.EventHandler(this.openIssueAgain_Click);
            // 
            // newIssue
            // 
            this.newIssue.Location = new System.Drawing.Point(332, 105);
            this.newIssue.Name = "newIssue";
            this.newIssue.Size = new System.Drawing.Size(154, 40);
            this.newIssue.TabIndex = 2;
            this.newIssue.Text = "Submit New Issue";
            this.newIssue.UseVisualStyleBackColor = true;
            this.newIssue.Click += new System.EventHandler(this.newIssue_Click);
            // 
            // openIssues
            // 
            this.openIssues.Location = new System.Drawing.Point(332, 151);
            this.openIssues.Name = "openIssues";
            this.openIssues.Size = new System.Drawing.Size(154, 40);
            this.openIssues.TabIndex = 3;
            this.openIssues.Text = "View Open Issues";
            this.openIssues.UseVisualStyleBackColor = true;
            this.openIssues.Click += new System.EventHandler(this.openIssues_Click);
            // 
            // completedIssue
            // 
            this.completedIssue.FormattingEnabled = true;
            this.completedIssue.Location = new System.Drawing.Point(13, 13);
            this.completedIssue.Name = "completedIssue";
            this.completedIssue.Size = new System.Drawing.Size(281, 355);
            this.completedIssue.TabIndex = 4;
            this.completedIssue.SelectedIndexChanged += new System.EventHandler(this.completedIssue_SelectedIndexChanged);
            // 
            // resolvedCounter
            // 
            this.resolvedCounter.AutoSize = true;
            this.resolvedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolvedCounter.Location = new System.Drawing.Point(374, 236);
            this.resolvedCounter.Name = "resolvedCounter";
            this.resolvedCounter.Size = new System.Drawing.Size(0, 17);
            this.resolvedCounter.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Resolved Issues";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(411, 339);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loadIssueData
            // 
            this.loadIssueData.Location = new System.Drawing.Point(314, 339);
            this.loadIssueData.Name = "loadIssueData";
            this.loadIssueData.Size = new System.Drawing.Size(75, 23);
            this.loadIssueData.TabIndex = 8;
            this.loadIssueData.Text = "Load";
            this.loadIssueData.UseVisualStyleBackColor = true;
            this.loadIssueData.Click += new System.EventHandler(this.loadIssueData_Click);
            // 
            // resolvedIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.loadIssueData);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolvedCounter);
            this.Controls.Add(this.completedIssue);
            this.Controls.Add(this.openIssues);
            this.Controls.Add(this.newIssue);
            this.Controls.Add(this.openIssueAgain);
            this.Controls.Add(this.issueDetails);
            this.Name = "resolvedIssues";
            this.Text = "View Resolved issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button issueDetails;
        private System.Windows.Forms.Button openIssueAgain;
        private System.Windows.Forms.Button newIssue;
        private System.Windows.Forms.Button openIssues;
        private System.Windows.Forms.ListBox completedIssue;
        private System.Windows.Forms.Label resolvedCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loadIssueData;
    }
}