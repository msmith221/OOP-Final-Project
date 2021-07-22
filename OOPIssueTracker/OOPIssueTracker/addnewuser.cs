using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace OOPIssueTracker
{
    public partial class addnewuser : Form
    {
        public addnewuser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //close the windowwwww
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string playerName = txtUsername.Text;
            string emailAddress = txtEmail.Text;
            string userIP = txtIP.Text;
            string userIPAccounts = txtOtherAccounts.Text;
            string userNotes = txtNotes.Text;
            /*Database db = new Database();
            MySqlCommand addnotes = new MySqlCommand("INSERT INTO `kiroshistory`(`playerName`, `userIP`, `ipAccounts`, `oldUser`, `userEmail`, `userNotes`) VALUES (@pname, @userIP, @ipAcc, @emailAdd, @pnotes)", db.getConnection());
            addnotes.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtUsername.Text;
            addnotes.Parameters.Add("@userIP", MySqlDbType.VarChar).Value = txtIP.Text;
            addnotes.Parameters.Add("@ipAcc", MySqlDbType.VarChar).Value = txtOtherAccounts.Text;
            addnotes.Parameters.Add("@emailAdd", MySqlDbType.VarChar).Value = txtEmail.Text;
            addnotes.Parameters.Add("@pnotes", MySqlDbType.VarChar).Value = txtNotes.Text;


            //open le connection plz
             db.openConnection();*/

            //again, old fashioned style :)
            string newLine = Environment.NewLine;
            System.IO.Directory.CreateDirectory(@"B:\Kiros Moderator Records\Account Information");
            System.IO.StreamWriter newUser;
            newUser = new System.IO.StreamWriter(@"B:\Kiros Moderator Records\Account Information\" + playerName + ".txt", false);
            newUser.WriteLine("Player Username: {0}" + newLine + "Player Email Address: {1}" + newLine + "User IP Address: {2}" + newLine + "Accounts on IP Address: {3}" + newLine + "Additional Notes: {4}", playerName, emailAddress, userIP, userIPAccounts, userNotes);
            newUser.Close();

            //yay you did it!
            MessageBox.Show("User created successfully.");

            //close it
            //db.closeConnection();
            this.Close();
        }

       /* public Boolean checkAccount()
        {
            Database db = new Database();

            String username = Convert.ToString(txtUsername);
            String ipaddress = Convert.ToString(txtIP);

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `modnotes` WHERE `Player Name` = @player, `Account IP` = @ipaddress", db.getConnection());

            command.Parameters.Add("@player", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@ipaddress", MySqlDbType.VarChar).Value = ipaddress;

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
        }*/
    }
}
