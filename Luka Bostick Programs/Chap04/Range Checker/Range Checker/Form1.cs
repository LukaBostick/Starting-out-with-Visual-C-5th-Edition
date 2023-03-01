using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable and initialize it with
                // the user's input.
                int number = int.Parse(inputTextBox.Text);

                // Check the number's range.
                if (number >= 1 && number <= 10)
                {
                    MessageBox.Show("That number is acceptable.");
                }
                else
                {
                    MessageBox.Show("That number is NOT acceptable.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
