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
using System.Security.Cryptography.X509Certificates;
using System.CodeDom.Compiler;
using System.Data.OleDb;
using MySqlX.XDevAPI.Common;

namespace OOPIssueTracker
{
    public partial class openIssues : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader newreader;


        string a;

        public openIssues()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitNew_Click(object sender, EventArgs e)
        {
            newIssueForm f2 = new newIssueForm();
            f2.ShowDialog();
        }

        private void resolvedIssues_Click(object sender, EventArgs e)
        {
            resolvedIssues f4 = new resolvedIssues();
            f4.ShowDialog();
        }

        private void openIssuesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (openIssuesBox.Items.Count == 0)
            {
                openIssuesBox.Text = "No open issues.";
            }
            //update le counter
            openIssueCounter.Text = openIssuesBox.Items.Count.ToString();
        }

        private void openIssueCounter_Click(object sender, EventArgs e)
        {

        }

        private void loadIssues_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlDataReader dr;
                Cursor.Current = Cursors.WaitCursor;
                db.openConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM issues";
                cmd.Connection = db.getConnection();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    openIssuesBox.Items.Add(dr["name"]);
                }
                db.closeConnection();
                dr.Close();
                Cursor.Current = Cursors.Default;
                loadIssues.Hide();
        }

        protected void deleteIssue_Click(object sender, EventArgs e)
        {
            if (openIssuesBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select an issue to remove.", "Blank Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i <= openIssuesBox.Items.Count - 1; i++)
                {
                    if (openIssuesBox.SelectedIndex.Equals(i))
                    {
                        DeleteRecord(openIssuesBox.Items[i].ToString());
                        MessageBox.Show("Issue record successfully removed.", "Issue Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                string remove = openIssuesBox.SelectedItem.ToString();
                openIssuesBox.Items.Remove(remove);
            }
        }

        private void DeleteRecord(object p)
        {
            string removalStatement = "DELETE FROM `issues` WHERE `name` = @name";
            Database db = new Database();
            try
            {
                db.openConnection();
                MySqlCommand com = new MySqlCommand(removalStatement, db.getConnection());
                com.Parameters.AddWithValue("@name", openIssuesBox.SelectedItem.ToString());
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Deletion Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            a = openIssuesBox.SelectedItem.ToString();
            viewIssue view = new viewIssue();
            view.ab(a.ToString());
            view.ShowDialog();
        }

        public string ItemValue
        {
            get { return openIssuesBox.SelectedItem.ToString();  }
        }

        public void SetSelectedItemValue(string value)
        {
            openIssuesBox.Items[openIssuesBox.SelectedIndex] = value;
        }

        private void ResolveRecord(object p)
        {
            string removalLine = "DELETE FROM `issues` WHERE `name` = @name";
            Database db = new Database();
            try
            {
                db.openConnection();
                MySqlCommand removeresol = new MySqlCommand(removalLine, db.getConnection());
                removeresol.Parameters.AddWithValue("@name", openIssuesBox.SelectedItem.ToString());
                removeresol.CommandType = CommandType.Text;
                removeresol.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Deletion Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void setIssueResolved_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Database db = new Database();

            string resolvedName = "";
            string resolvedURL = "";
            string resolvedSev = "";
            string resolvedType = "";
            string resolvedDetails = "";
            string reportDate = "";
            string resolvedDate = DateTime.Now.ToString();
            string resolvedVersion = "";
            string resolvedIDNumber = finalString;

            db.openConnection();
            MySqlCommand resolve = new MySqlCommand("SELECT `name`, `reportURL`, `severity`, `type`, `date`, `details`, `version` FROM `issues` WHERE `name` = @name", db.getConnection());
            resolve.Parameters.AddWithValue("@name", openIssuesBox.SelectedItem.ToString());
            MySqlDataReader reader = resolve.ExecuteReader();
            while (reader.Read())
            {
                resolvedName = reader.GetValue(0).ToString();
                resolvedURL = reader.GetValue(1).ToString();
                resolvedSev = reader.GetValue(2).ToString();
                resolvedType = reader.GetValue(3).ToString();
                reportDate = reader.GetValue(4).ToString();
                resolvedDetails = reader.GetValue(5).ToString();
                resolvedVersion = reader.GetValue(6).ToString();
            }
            db.closeConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `resolvedissues`(`type`,`severity`,`name`,`date`,`version`,`reportURL`,`details`,`issueID`,`resolvedDate`) VALUES (@type, @sev, @name, @date, @version, @report, @details, @ID, @resD)", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = resolvedType;
            command.Parameters.Add("@sev", MySqlDbType.VarChar).Value = resolvedSev;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = resolvedName;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = reportDate;
            command.Parameters.Add("@version", MySqlDbType.VarChar).Value = resolvedVersion;
            command.Parameters.Add("@report", MySqlDbType.VarChar).Value = resolvedURL;
            command.Parameters.Add("@details", MySqlDbType.VarChar).Value = resolvedDetails;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = resolvedIDNumber;
            command.Parameters.Add("@resD", MySqlDbType.VarChar).Value = resolvedDate;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Issue resolved successfully.");
            }
            else
            {
                MessageBox.Show("Issue resolve failure.");
            }
            db.closeConnection();


            db.openConnection();
            if (openIssuesBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select an issue to resolve.", "Blank Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i <= openIssuesBox.Items.Count - 1; i++)
                {
                    if (openIssuesBox.SelectedIndex.Equals(i))
                    {
                        ResolveRecord(openIssuesBox.Items[i].ToString());
                    }
                }
                string remove = openIssuesBox.SelectedItem.ToString();
                openIssuesBox.Items.Remove(remove);
            }
            db.closeConnection();
        }
    }
}
