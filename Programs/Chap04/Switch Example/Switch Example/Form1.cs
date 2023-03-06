using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int number;

            // Get the number.
            if (int.TryParse(numberTextBox.Text, out number))
            {
                // Display the day.
                switch (number)
                {
                    case 1:
                        dayOfWeekLabel.Text = "Sunday";
                        break;
                    case 2:
                        dayOfWeekLabel.Text = "Monday";
                        break;
                    case 3:
                        dayOfWeekLabel.Text = "Tuesday";
                        break;
                    case 4:
                        dayOfWeekLabel.Text = "Wednesday";
                        break;
                    case 5:
                        dayOfWeekLabel.Text = "Thursday";
                        break;
                    case 6:
                        dayOfWeekLabel.Text = "Friday";
                        break;
                    case 7:
                        dayOfWeekLabel.Text = "Saturday";
                        break;
                    default:
                        MessageBox.Show("Invalid number.");
                        break;
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
