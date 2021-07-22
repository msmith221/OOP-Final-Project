namespace OOPIssueTracker
{
    partial class kirosTracker
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
            this.newIssue = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.openIssues = new System.Windows.Forms.Button();
            this.resolvedIssues = new System.Windows.Forms.Button();
            this.submitModNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newIssue
            // 
            this.newIssue.Location = new System.Drawing.Point(38, 72);
            this.newIssue.Name = "newIssue";
            this.newIssue.Size = new System.Drawing.Size(142, 42);
            this.newIssue.TabIndex = 0;
            this.newIssue.Text = "Submit New Issue";
            this.newIssue.UseVisualStyleBackColor = true;
            this.newIssue.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(38, 216);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(142, 42);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // openIssues
            // 
            this.openIssues.Location = new System.Drawing.Point(38, 120);
            this.openIssues.Name = "openIssues";
            this.openIssues.Size = new System.Drawing.Size(142, 45);
            this.openIssues.TabIndex = 2;
            this.openIssues.Text = "View Open Issues";
            this.openIssues.UseVisualStyleBackColor = true;
            this.openIssues.Click += new System.EventHandler(this.openIssues_Click);
            // 
            // resolvedIssues
            // 
            this.resolvedIssues.Location = new System.Drawing.Point(38, 171);
            this.resolvedIssues.Name = "resolvedIssues";
            this.resolvedIssues.Size = new System.Drawing.Size(142, 39);
            this.resolvedIssues.TabIndex = 3;
            this.resolvedIssues.Text = "View Resolved Issues";
            this.resolvedIssues.UseVisualStyleBackColor = true;
            this.resolvedIssues.Click += new System.EventHandler(this.resolvedIssues_Click);
            // 
            // submitModNote
            // 
            this.submitModNote.Location = new System.Drawing.Point(38, 12);
            this.submitModNote.Name = "submitModNote";
            this.submitModNote.Size = new System.Drawing.Size(142, 54);
            this.submitModNote.TabIndex = 4;
            this.submitModNote.Text = "Submit New Mod Note";
            this.submitModNote.UseVisualStyleBackColor = true;
            this.submitModNote.Click += new System.EventHandler(this.submitModNote_Click);
            // 
            // kirosTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 270);
            this.Controls.Add(this.submitModNote);
            this.Controls.Add(this.resolvedIssues);
            this.Controls.Add(this.openIssues);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.newIssue);
            this.Name = "kirosTracker";
            this.Text = "Bug Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newIssue;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button openIssues;
        private System.Windows.Forms.Button resolvedIssues;
        private System.Windows.Forms.Button submitModNote;
    }
}

