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

namespace OOPIssueTracker
{
    public partial class actionhistory : Form
    {
        string z;
        public void zf(string f)
        {
            z = f.ToString();
        }

        public actionhistory()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            nameLabel.Text = z;
            string actionHistoryText = @"B:\Kiros Moderator Records\" + z + "\\ActionHistory.txt";

            string modNote = @"B:\Kiros Moderator Records\" + z + "\\ModNotes.txt";

            if (File.Exists(modNote))
            {
                string n = File.ReadAllText(@"B:\Kiros Moderator Records\" + z + "\\ModNotes.txt");
                textBox1.Text = n;
            }
            else
            {
                textBox1.Text = "No user mod notes.";
            }

            if (File.Exists(actionHistoryText))
            {
                string s = File.ReadAllText(@"B:\Kiros Moderator Records\" + z + "\\ActionHistory.txt");
                txtHistorySummary.Text = s;
            }
            else
            {
                txtHistorySummary.Text = "No user action history.";
            }

        }

        private void txtHistorySummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            System.IO.StreamWriter otherNotes;
            otherNotes = new System.IO.StreamWriter(@"B:\Kiros Moderator Records\" + z + "\\ModNotes.txt", false);
            otherNotes.WriteLine("----- NEW MOD NOTE -----" + newLine);
            otherNotes.WriteLine("{0}" + newLine + "{1}" + newLine, DateTime.Now, textBox1.Text);
            otherNotes.WriteLine("----- END NEW MOD NOTE -----" + newLine);
            otherNotes.Close();
        }
    }
}
