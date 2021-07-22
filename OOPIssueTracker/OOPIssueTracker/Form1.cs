using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPIssueTracker
{
    public partial class kirosTracker : Form
    {
        public kirosTracker()
        {
            InitializeComponent();
        }

        private bool DrawText = false;

        private void button1_Click(object sender, EventArgs e)
        {
            newIssueForm f2 = new newIssueForm();
            f2.ShowDialog();
        }

        private void openIssues_Click(object sender, EventArgs e)
        {
            openIssues f3 = new openIssues();
            f3.ShowDialog();
        }

        private void resolvedIssues_Click(object sender, EventArgs e)
        {
            resolvedIssues f4 = new resolvedIssues();
            f4.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout successful!");
            loginForm f6 = new loginForm();
            f6.ShowDialog();
            this.Close();
        }

        private void submitModNote_Click(object sender, EventArgs e)
        {
            modnotesub submitnew = new modnotesub();
            submitnew.ShowDialog();
        }
    }
}
