using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Numeric_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readValuesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold the numbers read from the file
                // and their total
                int number1, number2, number3, total;

                // A StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("NumericData.txt");

                // Read three numbers from the file.
                number1 = int.Parse(inputFile.ReadLine());
                number2 = int.Parse(inputFile.ReadLine());
                number3 = int.Parse(inputFile.ReadLine());

                // Calculate the total of the numbers.
                total = number1 + number2 + number3;

                // Display the total.
                MessageBox.Show("The total is " + total);

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
