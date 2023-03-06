using ExtensionMethods;
using System;
using System.Windows.Forms;

namespace Integer_Extension_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Clear the ListBox.
            resultsListBox.Items.Clear();

            // Make sure the number is an integer
            double dnum = double.Parse(numberTextBox.Text);
            if (dnum.IsWholeNumber())
            {
                resultsListBox.Items.Add("The number is an integer.");
                int inum = int.Parse(numberTextBox.Text);

                // Is the number even?
                if (inum.IsEven())
                {
                    resultsListBox.Items.Add("The number is even.");
                }
                else
                {
                    resultsListBox.Items.Add("The number is odd.");
                }

                // Is the number a multiple of 5?
                if (inum.IsMultipleOf(5))
                {
                    resultsListBox.Items.Add("The number is a multiple of 5.");
                }
                else
                {
                    resultsListBox.Items.Add("The number is not a multiple of 5.");
                }
            }
            else
            {
                MessageBox.Show("Enter an integer.");
            }
        }
    }
}
