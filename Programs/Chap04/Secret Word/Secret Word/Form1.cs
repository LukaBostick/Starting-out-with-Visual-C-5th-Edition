using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable and initialize it with
            // the user's input.
            string secretWord = inputTextBox.Text;

            // Did the user enter the correct secret word?
            if (secretWord == "Ariel")
            {
                MessageBox.Show("That is the correct secret word.");
            }
            else
            {
                MessageBox.Show("Sorry, that is NOT the secret word.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
