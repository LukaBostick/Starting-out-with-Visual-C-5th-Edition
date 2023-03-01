using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Change_Array_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an int array.
            int[] numbers = { 1, 2, 3 };

            // Display the number array's contents.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int value in numbers)
            {
                outputListBox.Items.Add(value);
            }

            // Pass the number array to the ChangeArray method.
            ChangeArray(numbers);

            // Display the number array's contents.
            outputListBox.Items.Add("After calling ChangeArray:");
            foreach (int value in numbers)
            {
                outputListBox.Items.Add(value);
            }
        }

        private void ChangeArray(int[] iArray)
        {
            const int NEW_SIZE = 5;

            // Make iArray reference a different array.
            iArray = new int[NEW_SIZE];

            // Set the new array's elements to 99.
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 99;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
