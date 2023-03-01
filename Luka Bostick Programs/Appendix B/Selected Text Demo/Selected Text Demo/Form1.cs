using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selected_Text_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Variables for hours, pay rate, and gross pay
            decimal hours, payRate, grossPay;

            // Clear any existing errors.
            ErrorProvider1.SetError(hoursTextBox, "");
            ErrorProvider1.SetError(payRateTextBox, "");

            // Get values and calculate gross pay.
            if (decimal.TryParse(hoursTextBox.Text, out hours))
            {
                if (decimal.TryParse(payRateTextBox.Text, out payRate))
                {
                    // Calculate the gross pay.
                    grossPay = hours * payRate;

                    // Display the gross pay.
                    grossPayLabel.Text = grossPay.ToString("c");
                }
                else
                {
                    // Invalid pay rate
                    ErrorProvider1.SetError(payRateTextBox,
                        "Pay rate must be numeric.");

                    // Select the invalid input.
                    payRateTextBox.Focus();
                    payRateTextBox.SelectionStart = 0;
                    payRateTextBox.SelectionLength = 
                        payRateTextBox.Text.Length;
                }
            }
            else
            {
                // Invalid hours
                ErrorProvider1.SetError(hoursTextBox,
                    "Hours must be numeric.");

                // Select the invalid input.
                hoursTextBox.Focus();
                hoursTextBox.SelectionStart = 0;
                hoursTextBox.SelectionLength = 
                    hoursTextBox.Text.Length;
            }
        }
    }
}
