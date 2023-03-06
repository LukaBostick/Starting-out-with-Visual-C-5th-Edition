using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Even_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsEven method accepts an int argument and returns
        // true if the argument is even, or false if it is odd.
        private bool IsEven(int number)
        {
            // Local variable to hold true or false
            bool numberIsEven;

            // Determine whether the number is even.
            if (number % 2 == 0)
            {
                numberIsEven = true;
            }
            else
            {
                numberIsEven = false;
            }

            // Return the result.
            return numberIsEven;
        }

        private void evenOrOddButton_Click(object sender, EventArgs e)
        {
            int number;     // To hold the number

            // Get the number.
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // Determine whether the number is even or odd.
                if (IsEven(number))
                {
                    MessageBox.Show("The number is even.");
                }
                else
                {
                    MessageBox.Show("The number is odd.");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter an integer please.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
