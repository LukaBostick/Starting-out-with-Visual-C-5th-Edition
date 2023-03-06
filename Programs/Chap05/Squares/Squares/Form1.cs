using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Constant for the maximum number
            const int MAX_VALUE = 10;

            // Loop counter
            int number;

            // Display the list of numbers and their squares.
            for (number = 1; number <= MAX_VALUE; number++)
            {
                outputListBox.Items.Add("The square of " +
                    number + " is " + (number * number));
            }
        }
    }
}
