using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace OOPIssueTracker
{
    public partial class resolvedIssues : Form
    {
        string c;
        Database db = new Database();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader dr;

        public resolvedIssues()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newIssue_Click(object sender, EventArgs e)
        {
            newIssueForm f2 = new newIssueForm();
            f2.ShowDialog();
        }

        private void openIssues_Click(object sender, EventArgs e)
        {
            openIssues f3 = new openIssues();
            f3.ShowDialog();
        }

        private void issueDetails_Click(object sender, EventArgs e)
        {
            c = completedIssue.SelectedItem.ToString();
            resolvedViewIssue resolveditems = new resolvedViewIssue();
            resolveditems.cd(c.ToString());
            resolveditems.ShowDialog();
        }

        private void completedIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            resolvedCounter.Text = completedIssue.Items.Count.ToString();
        }

        private void loadIssueData_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            db.openConnection();
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM resolvedissues";
            cmd.Connection = db.getConnection();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                completedIssue.Items.Add(dr["name"]);
            }
            db.closeConnection();
            Cursor.Current = Cursors.Default;
            loadIssueData.Hide();
        }

        private void openIssueAgain_Click(object sender, EventArgs e)
        {
            string resolvedName = "";
            string resolvedURL = "";
            string resolvedSev = "";
            string resolvedType = "";
            string resolvedDetails = "";
            string reportDate = "";
            string resolvedDate = DateTime.Now.ToString();
            string resolvedVersion = "";

            db.openConnection();
            MySqlCommand resolve = new MySqlCommand("SELECT `name`, `reportURL`, `severity`, `type`, `date`, `details`, `version` FROM `resolvedissues` WHERE `name` = @name", db.getConnection());
            resolve.Parameters.AddWithValue("@name", completedIssue.SelectedItem.ToString());
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

            MySqlCommand command = new MySqlCommand("INSERT INTO `issues`(`type`,`severity`,`name`,`date`,`version`,`reportURL`,`details`) VALUES (@type, @sev, @name, @date, @version, @report, @details)", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = resolvedType;
            command.Parameters.Add("@sev", MySqlDbType.VarChar).Value = resolvedSev;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = resolvedName;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = resolvedDate;
            command.Parameters.Add("@version", MySqlDbType.VarChar).Value = resolvedVersion;
            command.Parameters.Add("@report", MySqlDbType.VarChar).Value = resolvedURL;
            command.Parameters.Add("@details", MySqlDbType.VarChar).Value = resolvedDetails;


            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Issue re-opened successfully.");
            }
            else
            {
                MessageBox.Show("Issue re-open failure.");
            }
            db.closeConnection();


            db.openConnection();
            if (completedIssue.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select an issue to re-open.", "Blank Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i <= completedIssue.Items.Count - 1; i++)
                {
                    if (completedIssue.SelectedIndex.Equals(i))
                    {
                        ResolveRecord(completedIssue.Items[i].ToString());
                    }
                }
                string remove = completedIssue.SelectedItem.ToString();
                completedIssue.Items.Remove(remove);
            }
            db.closeConnection();
        }
        private void ResolveRecord(object p)
        {
            string removalLine = "DELETE FROM `resolvedissues` WHERE `name` = @name";
            Database db = new Database();
            try
            {
                db.openConnection();
                MySqlCommand removeresol = new MySqlCommand(removalLine, db.getConnection());
                removeresol.Parameters.AddWithValue("@name", completedIssue.SelectedItem.ToString());
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
    }
}
