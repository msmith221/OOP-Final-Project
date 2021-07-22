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

namespace OOPIssueTracker
{
    public partial class newIssueForm : Form
    {
        public newIssueForm()
        {
            InitializeComponent();
        }

        private void newIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openIssues_Click(object sender, EventArgs e)
        {
            openIssues f3 = new openIssues();
            f3.ShowDialog();
        }

        private void viewResolved_Click(object sender, EventArgs e)
        {
            resolvedIssues f4 = new resolvedIssues();
            f4.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //severity selection
            string severitySelection = "";
            string typeSelected = "";

            if (sevMedium.Checked == true)
            {
                severitySelection = "Medium";
            }
            if (sevHigh.Checked == true)
            {
                severitySelection = "High";
            }
            if (sevLow.Checked == true)
            {
                severitySelection = "Low";
            }
            if (sevUrgent.Checked == true)
            {
                severitySelection = "Urgent";
            }

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            string issueTypeSelected = issueType.SelectedItem.ToString();
            string severityLevel = severitySelection;
            string issueNameVal = issueName.Text;
            string issueReportDate = issueDate.Value.ToString("yyyy-MM-dd");
            string gameVersionSelect = gameVersion.Text;
            string reportThreadURL = reportLink.Text;
            string detailsSubmission = detailText.Text;
            string issueIDNumber = finalString;

            //enter the new data
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `issues`(`type`, `severity`, `name`, `date`, `version`, `reportURL`, `details`,`issueID`) VALUES (@type, @sev, @name, @date, @version, @report, @details, @ID)", db.getConnection());

            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = issueTypeSelected;
            command.Parameters.Add("@sev", MySqlDbType.VarChar).Value = severityLevel;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = issueNameVal;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = issueReportDate;
            command.Parameters.Add("@version", MySqlDbType.VarChar).Value = gameVersionSelect;
            command.Parameters.Add("@report", MySqlDbType.VarChar).Value = reportThreadURL;
            command.Parameters.Add("@details", MySqlDbType.VarChar).Value = detailsSubmission;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = issueIDNumber;

            //open the connection
            db.openConnection();

            //check if the password fields are the same
            //check if the username is the same and if there are empty fields
            if (!checkTextBoxesValues())
            {
              if (checkReport())
                 {
                        MessageBox.Show("This issue has already been reported.", "Issue Report Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                    else
                    {
                        //execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Issue report created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Issue report creation failure.");
                        }
                    }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Blank Fields Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close the connection
            db.closeConnection();
        }

        public Boolean checkTextBoxesValues()
        {
            string issueTypeSelected = issueType.SelectedIndex.ToString();
            string severityLevel = severitySelect.Text;
            string issueNameVal = issueName.Text;
            string issueReportDate = issueDate.Value.ToString("yyyy-MM-dd");
            string gameVersionSelect = gameVersion.Text;
            string reportThreadURL = reportLink.Text;
            string detailsSubmission = detailText.Text;

            if (issueTypeSelected == ("") || severityLevel == ("") || issueNameVal == ("") || issueReportDate == ("") || gameVersionSelect == ("") || reportThreadURL == ("") || detailsSubmission == (""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check if the issue exists via the report URL
        public Boolean checkReport()
        {
            Database db = new Database();

            String URL = reportLink.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `issues` WHERE `reportURL` = @report", db.getConnection());

            command.Parameters.Add("@report", MySqlDbType.VarChar).Value = reportLink.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if the username exists or not in the databse
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void issueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void issueType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            issueType.SelectedIndex.ToString("");

            if (sevMedium.Checked == true)
            {
                sevMedium.Checked = false;
            }
            if (sevHigh.Checked == true)
            {
                sevHigh.Checked = false;
            }
            if (sevLow.Checked == true)
            {
                sevLow.Checked = false;
            }
            if (sevUrgent.Checked == true)
            {
                sevUrgent.Checked = false;
            }

            issueName.Text = "";
            gameVersion.Text = "";
            issueDate.Text = "";
            reportLink.Text = "";
            detailText.Text = "";


        }
    }
}
