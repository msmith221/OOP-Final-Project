using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace OOPIssueTracker
{
    public partial class modnotesub : Form
    {

        Database db = new Database();
        string f;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader dr;
        public modnotesub()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //open a new form to display action history
            f = usersList.SelectedItem.ToString();
           actionhistory actionhistoryView = new actionhistory();
            actionhistoryView.zf(f.ToString());
            actionhistoryView.ShowDialog();
        }

        private void addNewPlayer_Click(object sender, EventArgs e)
        {
            addnewuser newUser = new addnewuser();
            newUser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountStatus = "";
            string statusReason = reasonText.Text;
            string actionText = "";
            string actionInfo = "";
            string startDate = statusStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = statusEndDate.Value.ToString("yyyy-MM-dd");
            string actionDateT = actionDate.Value.ToString("yyyy-MM-dd");
            string accountStatusComplete = "";
            string accountActionSummary = "";
            string accountActionHistory = "";
            string actionNotesAdded = actionNotes.Text;
            string evidenceURL = txtTicketURL.Text;
            string playerUsername = usersList.SelectedItem.ToString();

            //status summary
            if (permaSus.Checked == true)
            {
                endDate = "NULL";
                statusEndDate.Visible = false;
            }
            if (acctHealthy.Checked == true)
            {
                accountStatus = "Active / Healthy";
                accountStatusComplete = accountStatus;
            }
            if (acctSilenced.Checked == true)
            {
                accountStatus = "Post / PM Silenced";
                accountStatusComplete = accountStatus + " for " + statusReason + " on " + startDate + " until " + endDate;
                
            }
            if (acctTempSus.Checked == true)
            {
                accountStatus = "Temporarily Suspended";
                accountStatusComplete = accountStatus + " for " + statusReason + " on " + startDate + " until " + endDate;
                
            }
            if (acctPermaSus.Checked == true)
            {
                accountStatus = "Permanently Suspended";
                accountStatusComplete = accountStatus + " for " + statusReason + " on " + startDate;
                
            }

            //action summary to update current stuff and add onto history.
            string actionTypeText = "";
            string actionOwner = actionBy.Text;

            if (actionUpdate.Checked == true)
            {
                actionText = "Updating user mod notes.";
            }
            if (actionToSRem.Checked == true)
            {
                actionTypeText = "Reminder for Terms of Service bullet";
            }
            if (actionToSWarn.Checked == true)
            {
                actionTypeText = "Warning for Terms of Service bullet";
            }
            if (actionToSSus.Checked == true)
            {
                actionTypeText = "Suspension for Terms of Service bullet";
            }
            if (actionReminder.Checked == true)
            {
                actionTypeText = "Reminder for Code of Conduct bullet";
            }
            if (actionWarning.Checked == true)
            {
                actionTypeText = "Warning for Code of Conduct bullet";
            }
            if (actionSuspension.Checked == true)
            {
                actionTypeText = "Suspension for Code of Conduct bullet";
            }
            if (actionSilence.Checked == true)
            {
                actionTypeText = "Post / PM Silenced for";
            }
            if (actionUpdate.Checked == true)
            {
                actionTypeText = "Updating user mod notes/history.";
            }

                if (chkSection.Checked == true)
                {
                    actionText = reasonSelect.SelectedItem.ToString() + txtSection.Text;
                }
                else if (chkOther.Checked == true)
                {
                    actionText = txtOther.Text;
                }
                actionInfo = "Moderator Action: " + actionTypeText + " Section " + actionText + " on " + actionDateT + ". Action taken by: " + actionOwner;
                accountActionSummary = actionInfo + evidenceURL + " Moderator Action Notes: " + actionNotesAdded;


            //was gonna have this upload into the database but it's being an ass soooooo we do this old fashioned
            /*db.openConnection();
            MySqlCommand addnotes = new MySqlCommand("INSERT INTO `kiroshistory`(`playerName`, `userIP`, `oldUser`, `userEmail`, `userNotes`) VALUES (@pname, @userIP, @oldUser, @emailAdd, @pnotes)", db.getConnection());
            addnotes.Parameters.Add("@pname", MySqlDbType.VarChar).Value = usersList.SelectedItem.ToString();
            addnotes.Parameters.Add("@userIP", MySqlDbType.VarChar).Value = acctIPAddress.Text;
            addnotes.Parameters.Add("@oldUser", MySqlDbType.VarChar).Value = textBox1.Text;
            addnotes.Parameters.Add("@emailAdd", MySqlDbType.VarChar).Value = acctEmail.Text;
            addnotes.Parameters.Add("@pnotes", MySqlDbType.VarChar).Value = updateNotes.Text;*/

            var dir = @"B:\\Kiros Moderator Records\"+ playerUsername; // folder location

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string newLine = Environment.NewLine;
            System.IO.StreamWriter writeRecord;
            writeRecord = new System.IO.StreamWriter(@"B:\Kiros Moderator Records\"+playerUsername+"\\ActionHistory.txt", true);
            writeRecord.WriteLine("----- NEW ACTION RECORD -----" + newLine);
            writeRecord.WriteLine("Player Username: {0}" + newLine + "{1}" + newLine + "Ticket URL: {2}" + newLine + "Moderator Action Notes: {3}", playerUsername, actionInfo, evidenceURL, actionNotes.Text);
            writeRecord.WriteLine("Account Status: {0}" + newLine, accountStatusComplete);
            writeRecord.WriteLine("------ END OF NEW RECORD -----" + newLine);
            writeRecord.Close();


            MessageBox.Show("New mod note added successfully.", "User Mod Notes Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void acctIPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSection_CheckedChanged(object sender, EventArgs e)
        {
            txtSection.ReadOnly = false;
            chkOther.Enabled = false;
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOther.ReadOnly = false;
            chkSection.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = txtTicketURL.Text;
            if (url == "")
            {
                MessageBox.Show("ERROR: URL Field is blank.", "Blank URL Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        private void playerNameDrop_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            //Database db = new Database();
            //MySqlDataReader dr;
            //Cursor.Current = Cursors.WaitCursor;
            //db.openConnection();
            //cmd = new MySqlCommand();
            //cmd.CommandText = "SELECT * FROM `kiroshistory`";
            //cmd.Connection = db.getConnection();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    usersList.Items.Add(dr["Player Name"]);
            //}
            //db.closeConnection();
            //dr.Close();
            //Cursor.Current = Cursors.Default;
        }

        private void updateNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            usersList.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(@"B:\Kiros Moderator Records\Account Information");
            FileInfo[] smFiles = dinfo.GetFiles("*.txt");

            foreach (FileInfo fi in smFiles)
            {
                usersList.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
            }
        }

        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string playerUsername = usersList.SelectedItem.ToString();
            System.Diagnostics.Process.Start("notepad.exe", "B:\\Kiros Moderator Records\\Account Information\\"+ playerUsername);
        }
    }
}
