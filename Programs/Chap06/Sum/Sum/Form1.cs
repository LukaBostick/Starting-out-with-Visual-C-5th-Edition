using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Sum method accepts two int arguments
        // and returns the sum of the arguments.
        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare variables to hold two ages and their sum.
            int userAge, friendAge, combinedAge;

            // Get the user's age.
            if (int.TryParse(age1TextBox.Text, out userAge))
            {
                // Get the best friend's age age.
                if (int.TryParse(age2TextBox.Text, out friendAge))
                {
                    // Get the sum of the ages.
                    combinedAge = Sum(userAge, friendAge);

                    // Display the combined age.
                    combinedAgeLabel.Text = combinedAge.ToString();
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("Enter an integer for your age.");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter an integer for your age.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
