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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //make a new user

            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`displayname`, `emailaddress`, `username`, `password`) VALUES (@dn, @email, @user, @pass)", db.getConnection());

            command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = displayName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailRegBox.Text;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = usernameRegBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordRegBox.Text;

            //open the connection
            db.openConnection();

            //check if the password fields are the same
            //check if the username is the same and if there are empty fields
            if (!checkTextBoxesValues())
            {
                if (passwordRegBox.Text.Equals(confirmPassBox.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This username already exists. Please try a different username.", "Username Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account created successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Account creation failure.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Passwords do not match.", "Password Confirmation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please fill in all required fields.", "Blank Fields Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close the connection
            db.closeConnection();

        }

        //does it exist already?
        public Boolean checkUsername()
        {
            Database db = new Database();

            String username = usernameRegBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @user", db.getConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;

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

        //check if there are any empty fields
        public Boolean checkTextBoxesValues()
        {
            string displayNameVal = displayName.Text;
            string email = emailRegBox.Text;
            string username = usernameRegBox.Text;
            string password = passwordRegBox.Text;
            string passConfirmation = confirmPassBox.Text;

            if (displayNameVal.Equals("") || email.Equals("") || username.Equals("") || password.Equals("") || passConfirmation.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
