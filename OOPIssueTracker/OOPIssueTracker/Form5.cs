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
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            String username = usernameBox.Text;
            String password = passwordBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @user and `password` = @pass", db.getConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if the username exists or not
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MessageBox.Show("Login succesfull. Welcome " +username+ "!");
                kirosTracker success = new kirosTracker();
                success.ShowDialog();
                this.Close();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter a valid username.", "Please Enter a Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter your password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Account does not exist.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register f7 = new Register();
            f7.ShowDialog();
        }
    }
}
