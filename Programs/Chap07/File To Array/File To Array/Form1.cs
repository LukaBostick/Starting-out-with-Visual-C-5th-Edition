using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_To_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getValuesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an array to hold items read from the file.
                const int SIZE = 5;
                int[] numbers = new int[SIZE];

                // Counter variable to use in the loop
                int index = 0;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Values.txt");

                // Read the file's contents into the array.
                while (index < numbers.Length && !inputFile.EndOfStream)
                {
                    numbers[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file.
                inputFile.Close();

                // Display the array elements in the list box.
                foreach (int value in numbers)
                {
                    outputListBox.Items.Add(value);
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
