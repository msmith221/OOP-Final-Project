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
    public partial class viewIssue : Form
    {

        Database db = new Database();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader dr;

        string b;
        string setIssueName;
        public viewIssue()
        {
            InitializeComponent();
        }

        public void ab(string a)
        {
            b = a.ToString();
        }


        private void viewIssue_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openURL_Click(object sender, EventArgs e)
        {
            string url = ticketURL.Text;
            if (url == "")
            {
                MessageBox.Show("ERROR: URL Field is blank.", "Blank URL Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        private void changeStatus_Click(object sender, EventArgs e)
        {

        }

        public Boolean checkIssues()
        {
            Database db = new Database();


            String issueType = issueTypeLbl.Text;
            String status = issueStatus.Text;
            String reportDate = submissionDate.Text;
            String sevrate = issueSeverity.Text;
            String version = gameVersion.Text;
            String ticket = ticketURL.Text;
            String deets = detailsBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `issues` WHERE `name` = @name", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = b;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT `name`, `reportURL`, `severity`, `type`, `date`, `details`, `version` FROM `issues` WHERE `name` = @name", db.getConnection());
            cmd.Parameters.AddWithValue("@name", b);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                issueName.Text = reader.GetValue(0).ToString();
                ticketURL.Text = reader.GetValue(1).ToString();
                issueSeverity.Text = reader.GetValue(2).ToString();
                issueTypeLbl.Text = reader.GetValue(3).ToString();
                submissionDate.Text = reader.GetValue(4).ToString();
                detailsBox.Text = reader.GetValue(5).ToString();
                gameVersion.Text = reader.GetValue(6).ToString();
            }
            db.closeConnection();
            issueStatus.Text = "Open";
        }
    }
}
