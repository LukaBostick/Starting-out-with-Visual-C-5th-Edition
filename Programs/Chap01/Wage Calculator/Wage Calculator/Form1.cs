using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcGrossPayButton_Click(object sender, EventArgs e)
        {
            // Variables
            int hours;
            double payRate, grossPay;

            // Get data entered by the user.
            hours = int.Parse(hoursTextBox.Text);
            payRate = double.Parse(payRateTextBox.Text);

            // Calculate the gross pay.
            grossPay = hours * payRate;

            // Display the gross pay in a message box.
            MessageBox.Show("The gross pay is " + grossPay.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
