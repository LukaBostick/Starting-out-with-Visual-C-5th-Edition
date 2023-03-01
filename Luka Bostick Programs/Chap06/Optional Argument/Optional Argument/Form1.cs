using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optional_Argument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The ShowTax method displays the sales tax for an item.
        private void ShowTax(decimal price, decimal taxRate = 0.07m)
        {
            // Calculate the tax.
            decimal tax = price * taxRate;

            // Display the tax.
            MessageBox.Show("The tax is " + tax.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void showTaxButton_Click(object sender, EventArgs e)
        {
            // Variable to hold the item's price.
            decimal itemPrice;

            // Get the item's price.
            if (decimal.TryParse(priceTextBox.Text, out itemPrice))
            {
                // Show the tax at the default tax rate.
                ShowTax(itemPrice);

                // Show the tax at 8 percent.
                ShowTax(itemPrice, 0.08m);
            }
            else
            {
                // Error message for invalid price
                MessageBox.Show("Invalid value for price.");
            }
        }
    }
}
