using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredentialLogger
{
    public partial class Form1 : Form
    {
        // Array containing valid passwords
        private string[] passwords = { "7GxjUb", "rJ96qd",
                                       "6AaPb7", "4PnmSX"};

        public Form1()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // Flag for validity
            bool valid = false;

            // Check the password
            foreach(string password in passwords)
            {
                if (passwordTextBox.Text == password)
                    valid = true;
            }

            // Display the results
            if (valid)
                MessageBox.Show("Password accepted");
            else
                MessageBox.Show("Password not found");
        }
    }
}
