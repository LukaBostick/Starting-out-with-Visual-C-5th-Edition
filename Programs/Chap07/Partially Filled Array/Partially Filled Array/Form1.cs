using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Partially_Filled_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an array to hold items read from the file.
                const int SIZE = 100;
                int[] numbers = new int[SIZE];

                // Variable to hold the number of items stored in
                // the array 
                int count = 0;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Values.txt");

                // Read the file's contents into the array until the
                // end of the file is reached, or the array is full.
                while (!inputFile.EndOfStream && count < numbers.Length)
                {
                    // Read the next item from the file.
                    numbers[count] = int.Parse(inputFile.ReadLine());

                    // Increment count.
                    count++;
                }

                // Close the file.
                inputFile.Close();

                // Display the array elements in the list box.
                outputListBox.Items.Add("The file contains " + count +
                    " items:");

                for (int index = 0; index < count; index++)
                {
                    outputListBox.Items.Add(numbers[index]);
                }
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
