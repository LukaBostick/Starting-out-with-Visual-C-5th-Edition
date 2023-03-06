using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Max
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The ShowMax method accpets two int arguments
        // and displays the one that is greatest (or
        // indicates whether they are equal.)
        private void ShowMax(int num1, int num2)
        {
            if (num1 == num2)
            {
                MessageBox.Show("The numbers are equal.");
            }
            else if (num1 > num2)
            {
                MessageBox.Show(num1 + " is the greatest.");
            }
            else
            {
                MessageBox.Show(num2 + " is the greatest.");
            }
        }

        private void showGreatestButton_Click(object sender, EventArgs e)
        {
            int number1, number2;   // To hold the two numbers

            // Get the two numbers and display the greatest.
            if (int.TryParse(number1TextBox.Text, out number1))
            {
                if (int.TryParse(number2TextBox.Text, out number2))
                {
                    ShowMax(number1, number2);
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("Enter integer values only please.");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter integer values only please.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
