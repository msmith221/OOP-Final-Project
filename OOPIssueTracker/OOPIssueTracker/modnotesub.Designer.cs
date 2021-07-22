namespace OOPIssueTracker
{
    partial class modnotesub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modnotesub));
            this.submitNewNote = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewPlayer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acctPermaSus = new System.Windows.Forms.RadioButton();
            this.acctTempSus = new System.Windows.Forms.RadioButton();
            this.acctSilenced = new System.Windows.Forms.RadioButton();
            this.acctHealthy = new System.Windows.Forms.RadioButton();
            this.StatusInfo = new System.Windows.Forms.GroupBox();
            this.permaSus = new System.Windows.Forms.CheckBox();
            this.statusEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Reason = new System.Windows.Forms.Label();
            this.reasonText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.actionUpdate = new System.Windows.Forms.RadioButton();
            this.actionSilence = new System.Windows.Forms.RadioButton();
            this.actionToSSus = new System.Windows.Forms.RadioButton();
            this.actionToSWarn = new System.Windows.Forms.RadioButton();
            this.actionToSRem = new System.Windows.Forms.RadioButton();
            this.actionSuspension = new System.Windows.Forms.RadioButton();
            this.actionWarning = new System.Windows.Forms.RadioButton();
            this.actionReminder = new System.Windows.Forms.RadioButton();
            this.ActionInfo = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.actionBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.actionDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTicketURL = new System.Windows.Forms.TextBox();
            this.ticketURL = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.chkSection = new System.Windows.Forms.CheckBox();
            this.reasonSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.actionNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.StatusInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ActionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitNewNote
            // 
            this.submitNewNote.Location = new System.Drawing.Point(431, 532);
            this.submitNewNote.Name = "submitNewNote";
            this.submitNewNote.Size = new System.Drawing.Size(75, 23);
            this.submitNewNote.TabIndex = 1;
            this.submitNewNote.Text = "Submit";
            this.submitNewNote.UseVisualStyleBackColor = true;
            this.submitNewNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 532);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username Not Shown?";
            // 
            // addNewPlayer
            // 
            this.addNewPlayer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewPlayer.BackgroundImage")));
            this.addNewPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewPlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addNewPlayer.FlatAppearance.BorderSize = 2;
            this.addNewPlayer.Location = new System.Drawing.Point(135, 1);
            this.addNewPlayer.Name = "addNewPlayer";
            this.addNewPlayer.Size = new System.Drawing.Size(33, 28);
            this.addNewPlayer.TabIndex = 7;
            this.addNewPlayer.UseVisualStyleBackColor = false;
            this.addNewPlayer.Click += new System.EventHandler(this.addNewPlayer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 22);
            this.button4.TabIndex = 8;
            this.button4.Text = "View Action History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.acctPermaSus);
            this.groupBox1.Controls.Add(this.acctTempSus);
            this.groupBox1.Controls.Add(this.acctSilenced);
            this.groupBox1.Controls.Add(this.acctHealthy);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Status";
            // 
            // acctPermaSus
            // 
            this.acctPermaSus.AutoSize = true;
            this.acctPermaSus.Location = new System.Drawing.Point(7, 91);
            this.acctPermaSus.Name = "acctPermaSus";
            this.acctPermaSus.Size = new System.Drawing.Size(164, 17);
            this.acctPermaSus.TabIndex = 3;
            this.acctPermaSus.TabStop = true;
            this.acctPermaSus.Text = "Permanently Suspended for...";
            this.acctPermaSus.UseVisualStyleBackColor = true;
            this.acctPermaSus.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // acctTempSus
            // 
            this.acctTempSus.AutoSize = true;
            this.acctTempSus.Location = new System.Drawing.Point(7, 67);
            this.acctTempSus.Name = "acctTempSus";
            this.acctTempSus.Size = new System.Drawing.Size(103, 17);
            this.acctTempSus.TabIndex = 2;
            this.acctTempSus.TabStop = true;
            this.acctTempSus.Text = "Suspended for...";
            this.acctTempSus.UseVisualStyleBackColor = true;
            // 
            // acctSilenced
            // 
            this.acctSilenced.AutoSize = true;
            this.acctSilenced.Location = new System.Drawing.Point(7, 44);
            this.acctSilenced.Name = "acctSilenced";
            this.acctSilenced.Size = new System.Drawing.Size(66, 17);
            this.acctSilenced.TabIndex = 1;
            this.acctSilenced.TabStop = true;
            this.acctSilenced.Text = "Silenced";
            this.acctSilenced.UseVisualStyleBackColor = true;
            // 
            // acctHealthy
            // 
            this.acctHealthy.AutoSize = true;
            this.acctHealthy.Location = new System.Drawing.Point(7, 20);
            this.acctHealthy.Name = "acctHealthy";
            this.acctHealthy.Size = new System.Drawing.Size(102, 17);
            this.acctHealthy.TabIndex = 0;
            this.acctHealthy.TabStop = true;
            this.acctHealthy.Text = "Active / Healthy";
            this.acctHealthy.UseVisualStyleBackColor = true;
            // 
            // StatusInfo
            // 
            this.StatusInfo.Controls.Add(this.permaSus);
            this.StatusInfo.Controls.Add(this.statusEndDate);
            this.StatusInfo.Controls.Add(this.label5);
            this.StatusInfo.Controls.Add(this.statusStartDate);
            this.StatusInfo.Controls.Add(this.label4);
            this.StatusInfo.Controls.Add(this.Reason);
            this.StatusInfo.Controls.Add(this.reasonText);
            this.StatusInfo.Location = new System.Drawing.Point(224, 155);
            this.StatusInfo.Name = "StatusInfo";
            this.StatusInfo.Size = new System.Drawing.Size(285, 133);
            this.StatusInfo.TabIndex = 10;
            this.StatusInfo.TabStop = false;
            this.StatusInfo.Text = "Information";
            // 
            // permaSus
            // 
            this.permaSus.AutoSize = true;
            this.permaSus.Location = new System.Drawing.Point(131, 98);
            this.permaSus.Name = "permaSus";
            this.permaSus.Size = new System.Drawing.Size(83, 17);
            this.permaSus.TabIndex = 6;
            this.permaSus.Text = "Permanent?";
            this.permaSus.UseVisualStyleBackColor = true;
            // 
            // statusEndDate
            // 
            this.statusEndDate.Location = new System.Drawing.Point(64, 71);
            this.statusEndDate.Name = "statusEndDate";
            this.statusEndDate.Size = new System.Drawing.Size(200, 20);
            this.statusEndDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // statusStartDate
            // 
            this.statusStartDate.Location = new System.Drawing.Point(63, 44);
            this.statusStartDate.Name = "statusStartDate";
            this.statusStartDate.Size = new System.Drawing.Size(200, 20);
            this.statusStartDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date";
            // 
            // Reason
            // 
            this.Reason.AutoSize = true;
            this.Reason.Location = new System.Drawing.Point(13, 22);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(44, 13);
            this.Reason.TabIndex = 1;
            this.Reason.Text = "Reason";
            // 
            // reasonText
            // 
            this.reasonText.Location = new System.Drawing.Point(63, 19);
            this.reasonText.Name = "reasonText";
            this.reasonText.Size = new System.Drawing.Size(187, 20);
            this.reasonText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actionUpdate);
            this.groupBox3.Controls.Add(this.actionSilence);
            this.groupBox3.Controls.Add(this.actionToSSus);
            this.groupBox3.Controls.Add(this.actionToSWarn);
            this.groupBox3.Controls.Add(this.actionToSRem);
            this.groupBox3.Controls.Add(this.actionSuspension);
            this.groupBox3.Controls.Add(this.actionWarning);
            this.groupBox3.Controls.Add(this.actionReminder);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 219);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Taken";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // actionUpdate
            // 
            this.actionUpdate.AutoSize = true;
            this.actionUpdate.Location = new System.Drawing.Point(7, 188);
            this.actionUpdate.Name = "actionUpdate";
            this.actionUpdate.Size = new System.Drawing.Size(185, 17);
            this.actionUpdate.TabIndex = 7;
            this.actionUpdate.TabStop = true;
            this.actionUpdate.Text = "Updating User Mod Notes / Other";
            this.actionUpdate.UseVisualStyleBackColor = true;
            // 
            // actionSilence
            // 
            this.actionSilence.AutoSize = true;
            this.actionSilence.Location = new System.Drawing.Point(7, 164);
            this.actionSilence.Name = "actionSilence";
            this.actionSilence.Size = new System.Drawing.Size(111, 17);
            this.actionSilence.TabIndex = 6;
            this.actionSilence.TabStop = true;
            this.actionSilence.Text = "PM / Post Silence";
            this.actionSilence.UseVisualStyleBackColor = true;
            // 
            // actionToSSus
            // 
            this.actionToSSus.AutoSize = true;
            this.actionToSSus.Location = new System.Drawing.Point(7, 140);
            this.actionToSSus.Name = "actionToSSus";
            this.actionToSSus.Size = new System.Drawing.Size(103, 17);
            this.actionToSSus.TabIndex = 5;
            this.actionToSSus.TabStop = true;
            this.actionToSSus.Text = "ToS Suspension";
            this.actionToSSus.UseVisualStyleBackColor = true;
            // 
            // actionToSWarn
            // 
            this.actionToSWarn.AutoSize = true;
            this.actionToSWarn.Location = new System.Drawing.Point(7, 116);
            this.actionToSWarn.Name = "actionToSWarn";
            this.actionToSWarn.Size = new System.Drawing.Size(88, 17);
            this.actionToSWarn.TabIndex = 4;
            this.actionToSWarn.TabStop = true;
            this.actionToSWarn.Text = "ToS Warning";
            this.actionToSWarn.UseVisualStyleBackColor = true;
            // 
            // actionToSRem
            // 
            this.actionToSRem.AutoSize = true;
            this.actionToSRem.Location = new System.Drawing.Point(7, 92);
            this.actionToSRem.Name = "actionToSRem";
            this.actionToSRem.Size = new System.Drawing.Size(93, 17);
            this.actionToSRem.TabIndex = 3;
            this.actionToSRem.TabStop = true;
            this.actionToSRem.Text = "ToS Reminder";
            this.actionToSRem.UseVisualStyleBackColor = true;
            // 
            // actionSuspension
            // 
            this.actionSuspension.AutoSize = true;
            this.actionSuspension.Location = new System.Drawing.Point(7, 68);
            this.actionSuspension.Name = "actionSuspension";
            this.actionSuspension.Size = new System.Drawing.Size(103, 17);
            this.actionSuspension.TabIndex = 2;
            this.actionSuspension.TabStop = true;
            this.actionSuspension.Text = "CoC Suspension";
            this.actionSuspension.UseVisualStyleBackColor = true;
            // 
            // actionWarning
            // 
            this.actionWarning.AutoSize = true;
            this.actionWarning.Location = new System.Drawing.Point(7, 44);
            this.actionWarning.Name = "actionWarning";
            this.actionWarning.Size = new System.Drawing.Size(88, 17);
            this.actionWarning.TabIndex = 1;
            this.actionWarning.TabStop = true;
            this.actionWarning.Text = "CoC Warning";
            this.actionWarning.UseVisualStyleBackColor = true;
            // 
            // actionReminder
            // 
            this.actionReminder.AutoSize = true;
            this.actionReminder.Location = new System.Drawing.Point(7, 20);
            this.actionReminder.Name = "actionReminder";
            this.actionReminder.Size = new System.Drawing.Size(93, 17);
            this.actionReminder.TabIndex = 0;
            this.actionReminder.TabStop = true;
            this.actionReminder.Text = "CoC Reminder";
            this.actionReminder.UseVisualStyleBackColor = true;
            // 
            // ActionInfo
            // 
            this.ActionInfo.Controls.Add(this.button3);
            this.ActionInfo.Controls.Add(this.actionBy);
            this.ActionInfo.Controls.Add(this.label8);
            this.ActionInfo.Controls.Add(this.actionDate);
            this.ActionInfo.Controls.Add(this.label7);
            this.ActionInfo.Controls.Add(this.txtTicketURL);
            this.ActionInfo.Controls.Add(this.ticketURL);
            this.ActionInfo.Controls.Add(this.txtOther);
            this.ActionInfo.Controls.Add(this.chkOther);
            this.ActionInfo.Controls.Add(this.txtSection);
            this.ActionInfo.Controls.Add(this.chkSection);
            this.ActionInfo.Controls.Add(this.reasonSelect);
            this.ActionInfo.Controls.Add(this.label6);
            this.ActionInfo.Location = new System.Drawing.Point(224, 293);
            this.ActionInfo.Name = "ActionInfo";
            this.ActionInfo.Size = new System.Drawing.Size(285, 230);
            this.ActionInfo.TabIndex = 12;
            this.ActionInfo.TabStop = false;
            this.ActionInfo.Text = "Information";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "Open Ticket";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // actionBy
            // 
            this.actionBy.FormattingEnabled = true;
            this.actionBy.Items.AddRange(new object[] {
            "Slain",
            "Camashi",
            "Skar",
            "Seijith",
            "Bunnylions",
            "Vaynrat"});
            this.actionBy.Location = new System.Drawing.Point(101, 127);
            this.actionBy.Name = "actionBy";
            this.actionBy.Size = new System.Drawing.Size(170, 21);
            this.actionBy.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Action Taken by";
            // 
            // actionDate
            // 
            this.actionDate.Location = new System.Drawing.Point(101, 100);
            this.actionDate.Name = "actionDate";
            this.actionDate.Size = new System.Drawing.Size(166, 20);
            this.actionDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Action Taken on";
            // 
            // txtTicketURL
            // 
            this.txtTicketURL.Location = new System.Drawing.Point(77, 168);
            this.txtTicketURL.Name = "txtTicketURL";
            this.txtTicketURL.Size = new System.Drawing.Size(187, 20);
            this.txtTicketURL.TabIndex = 7;
            // 
            // ticketURL
            // 
            this.ticketURL.AutoSize = true;
            this.ticketURL.Location = new System.Drawing.Point(2, 169);
            this.ticketURL.Name = "ticketURL";
            this.ticketURL.Size = new System.Drawing.Size(62, 13);
            this.ticketURL.TabIndex = 6;
            this.ticketURL.Text = "Ticket URL";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(81, 71);
            this.txtOther.Name = "txtOther";
            this.txtOther.ReadOnly = true;
            this.txtOther.Size = new System.Drawing.Size(183, 20);
            this.txtOther.TabIndex = 5;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(16, 71);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(58, 17);
            this.chkOther.TabIndex = 4;
            this.chkOther.Text = "Other?";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(167, 44);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(96, 20);
            this.txtSection.TabIndex = 3;
            // 
            // chkSection
            // 
            this.chkSection.AutoSize = true;
            this.chkSection.Location = new System.Drawing.Point(16, 47);
            this.chkSection.Name = "chkSection";
            this.chkSection.Size = new System.Drawing.Size(145, 17);
            this.chkSection.TabIndex = 2;
            this.chkSection.Text = "Specified section? (ex. a)";
            this.chkSection.UseVisualStyleBackColor = true;
            this.chkSection.CheckedChanged += new System.EventHandler(this.chkSection_CheckedChanged);
            // 
            // reasonSelect
            // 
            this.reasonSelect.FormattingEnabled = true;
            this.reasonSelect.Items.AddRange(new object[] {
            "CoC 1.1",
            "CoC 1.2",
            "CoC 1.3",
            "CoC 1.4",
            "CoC 1.5",
            "CoC 1.6",
            "CoC 1.7",
            "CoC 1.8",
            "CoC 1.9",
            "CoC 1.10",
            "CoC 1.11",
            "CoC 1.12",
            "CoC 2.1",
            "CoC 2.2",
            "CoC 2.3",
            "CoC 2.4",
            "CoC 3.1",
            "CoC 3.2",
            "CoC 3.3"});
            this.reasonSelect.Location = new System.Drawing.Point(59, 20);
            this.reasonSelect.Name = "reasonSelect";
            this.reasonSelect.Size = new System.Drawing.Size(205, 21);
            this.reasonSelect.TabIndex = 1;
            this.reasonSelect.Text = "Select Reason for Action Taken";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reason";
            // 
            // actionNotes
            // 
            this.actionNotes.Location = new System.Drawing.Point(229, 52);
            this.actionNotes.Multiline = true;
            this.actionNotes.Name = "actionNotes";
            this.actionNotes.Size = new System.Drawing.Size(277, 95);
            this.actionNotes.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(226, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Action Notes";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // usersList
            // 
            this.usersList.FormattingEnabled = true;
            this.usersList.Location = new System.Drawing.Point(10, 52);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(202, 95);
            this.usersList.TabIndex = 17;
            this.usersList.SelectedIndexChanged += new System.EventHandler(this.usersList_SelectedIndexChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(174, 5);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(68, 21);
            this.loadBtn.TabIndex = 18;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "View Account Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modnotesub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.actionNotes);
            this.Controls.Add(this.ActionInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StatusInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addNewPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submitNewNote);
            this.Name = "modnotesub";
            this.Text = "Submit New Mod Note";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StatusInfo.ResumeLayout(false);
            this.StatusInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ActionInfo.ResumeLayout(false);
            this.ActionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitNewNote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewPlayer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton acctPermaSus;
        private System.Windows.Forms.RadioButton acctTempSus;
        private System.Windows.Forms.RadioButton acctSilenced;
        private System.Windows.Forms.RadioButton acctHealthy;
        private System.Windows.Forms.GroupBox StatusInfo;
        private System.Windows.Forms.CheckBox permaSus;
        private System.Windows.Forms.DateTimePicker statusEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker statusStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Reason;
        private System.Windows.Forms.TextBox reasonText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton actionWarning;
        private System.Windows.Forms.RadioButton actionReminder;
        private System.Windows.Forms.RadioButton actionUpdate;
        private System.Windows.Forms.RadioButton actionSilence;
        private System.Windows.Forms.RadioButton actionToSSus;
        private System.Windows.Forms.RadioButton actionToSWarn;
        private System.Windows.Forms.RadioButton actionToSRem;
        private System.Windows.Forms.RadioButton actionSuspension;
        private System.Windows.Forms.GroupBox ActionInfo;
        private System.Windows.Forms.ComboBox reasonSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.CheckBox chkSection;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox actionBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker actionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTicketURL;
        private System.Windows.Forms.Label ticketURL;
        private System.Windows.Forms.TextBox actionNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button button1;
    }
}