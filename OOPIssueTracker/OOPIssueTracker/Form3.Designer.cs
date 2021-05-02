namespace OOPIssueTracker
{
    partial class openIssues
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
            this.closeButton = new System.Windows.Forms.Button();
            this.openIssueCounter = new System.Windows.Forms.Label();
            this.resolvedIssues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.submitNew = new System.Windows.Forms.Button();
            this.deleteIssue = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.openIssuesBox = new System.Windows.Forms.ListBox();
            this.loadIssues = new System.Windows.Forms.Button();
            this.setIssueResolved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(419, 300);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openIssueCounter
            // 
            this.openIssueCounter.AutoSize = true;
            this.openIssueCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openIssueCounter.Location = new System.Drawing.Point(384, 236);
            this.openIssueCounter.Name = "openIssueCounter";
            this.openIssueCounter.Size = new System.Drawing.Size(0, 17);
            this.openIssueCounter.TabIndex = 14;
            this.openIssueCounter.Click += new System.EventHandler(this.openIssueCounter_Click);
            // 
            // resolvedIssues
            // 
            this.resolvedIssues.Location = new System.Drawing.Point(327, 144);
            this.resolvedIssues.Name = "resolvedIssues";
            this.resolvedIssues.Size = new System.Drawing.Size(167, 48);
            this.resolvedIssues.TabIndex = 13;
            this.resolvedIssues.Text = "View Resolved Issues";
            this.resolvedIssues.UseVisualStyleBackColor = true;
            this.resolvedIssues.Click += new System.EventHandler(this.resolvedIssues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Open Issues";
            // 
            // submitNew
            // 
            this.submitNew.Location = new System.Drawing.Point(327, 94);
            this.submitNew.Name = "submitNew";
            this.submitNew.Size = new System.Drawing.Size(167, 44);
            this.submitNew.TabIndex = 11;
            this.submitNew.Text = "Submit New Issue";
            this.submitNew.UseVisualStyleBackColor = true;
            this.submitNew.Click += new System.EventHandler(this.submitNew_Click);
            // 
            // deleteIssue
            // 
            this.deleteIssue.Location = new System.Drawing.Point(327, 47);
            this.deleteIssue.Name = "deleteIssue";
            this.deleteIssue.Size = new System.Drawing.Size(167, 41);
            this.deleteIssue.TabIndex = 10;
            this.deleteIssue.Text = "Delete Issue";
            this.deleteIssue.UseVisualStyleBackColor = true;
            this.deleteIssue.Click += new System.EventHandler(this.deleteIssue_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(327, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(167, 38);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "View Issue Details";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // openIssuesBox
            // 
            this.openIssuesBox.FormattingEnabled = true;
            this.openIssuesBox.Location = new System.Drawing.Point(12, 3);
            this.openIssuesBox.Name = "openIssuesBox";
            this.openIssuesBox.Size = new System.Drawing.Size(305, 277);
            this.openIssuesBox.TabIndex = 8;
            this.openIssuesBox.SelectedIndexChanged += new System.EventHandler(this.openIssuesBox_SelectedIndexChanged);
            // 
            // loadIssues
            // 
            this.loadIssues.Location = new System.Drawing.Point(338, 300);
            this.loadIssues.Name = "loadIssues";
            this.loadIssues.Size = new System.Drawing.Size(75, 23);
            this.loadIssues.TabIndex = 16;
            this.loadIssues.Text = "Load";
            this.loadIssues.UseVisualStyleBackColor = false;
            this.loadIssues.Click += new System.EventHandler(this.loadIssues_Click);
            // 
            // setIssueResolved
            // 
            this.setIssueResolved.Location = new System.Drawing.Point(43, 300);
            this.setIssueResolved.Name = "setIssueResolved";
            this.setIssueResolved.Size = new System.Drawing.Size(230, 23);
            this.setIssueResolved.TabIndex = 17;
            this.setIssueResolved.Text = "Resolve Selected Issue";
            this.setIssueResolved.UseVisualStyleBackColor = true;
            this.setIssueResolved.Click += new System.EventHandler(this.setIssueResolved_Click);
            // 
            // openIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 335);
            this.Controls.Add(this.setIssueResolved);
            this.Controls.Add(this.loadIssues);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openIssueCounter);
            this.Controls.Add(this.resolvedIssues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitNew);
            this.Controls.Add(this.deleteIssue);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.openIssuesBox);
            this.Name = "openIssues";
            this.Text = "View Open Issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label openIssueCounter;
        private System.Windows.Forms.Button resolvedIssues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitNew;
        private System.Windows.Forms.Button deleteIssue;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ListBox openIssuesBox;
        private System.Windows.Forms.Button loadIssues;
        private System.Windows.Forms.Button setIssueResolved;
    }
}