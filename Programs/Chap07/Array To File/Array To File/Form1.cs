using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Array_To_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an array with some values.
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Create the file and get a StreamWriter object.
                outputFile = File.CreateText("Values.txt");

                // Write the array's contents to the file.
                for (int index = 0; index < numbers.Length; index++)
                {
                    outputFile.WriteLine(numbers[index]);
                }

                // Close the file.
                outputFile.Close();

                // Let the user know it's done.
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
