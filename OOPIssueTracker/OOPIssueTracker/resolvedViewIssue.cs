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
    public partial class resolvedViewIssue : Form
    {

        Database db = new Database();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader dr;

        string d;

        public resolvedViewIssue()
        {
            InitializeComponent();
        }

        public void cd(string c)
        {
            d = c.ToString();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT `name`, `reportURL`, `severity`, `type`, `date`, `details`, `version`, `issueID`, `resolvedDate`, `Notes` FROM `resolvedissues` WHERE `name` = @name", db.getConnection());
            cmd.Parameters.AddWithValue("@name", d);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resolvedName.Text = reader.GetValue(0).ToString();
                reportURLBox.Text = reader.GetValue(1).ToString();
                severity.Text = reader.GetValue(2).ToString();
                type.Text = reader.GetValue(3).ToString();
                reportDate.Text = reader.GetValue(4).ToString();
                detailsBox.Text = reader.GetValue(5).ToString();
                version.Text = reader.GetValue(6).ToString();
                idnumber.Text = reader.GetValue(7).ToString();
                resolveDate.Text = reader.GetValue(8).ToString();
                notes.Text = reader.GetValue(9).ToString();
            }
            db.closeConnection();
            issueStatus.Text = "Resolved";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand addnotes = new MySqlCommand("UPDATE `resolvedissues` SET `Notes` = @notes WHERE `name` = @name", db.getConnection());
            addnotes.Parameters.Add("@notes", MySqlDbType.VarChar).Value = notes.Text;
            addnotes.Parameters.AddWithValue("@name", resolvedName.Text);
            MySqlDataReader update = addnotes.ExecuteReader();
            while (update.Read())
            {
                resolvedName.Text = update.GetValue(1).ToString();
            }
            db.closeConnection();
            MessageBox.Show("New issue note added successfully.", "Issue Notes Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openURL_Click(object sender, EventArgs e)
        {
            string url = reportURLBox.Text;
            if (url == "")
            {
                MessageBox.Show("ERROR: URL Field is blank.", "Blank URL Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
