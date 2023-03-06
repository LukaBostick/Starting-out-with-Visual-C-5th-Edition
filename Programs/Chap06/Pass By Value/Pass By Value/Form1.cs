using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pass_By_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int number = 99;

            // Display the value of number.
            MessageBox.Show("The value of number is " + number);

            // Call ChangeMe, passing number as an argument.
            ChangeMe(number);

            // Display the value of number again.
            MessageBox.Show("The value of number is " + number);
        }

        private void ChangeMe(int myValue)
        {
            // Change the value of the myValue parameter.
            myValue = 0;

            // Display the value of myValue.
            MessageBox.Show("In ChangeMe, myValue is " + myValue);
        }
    }
}
