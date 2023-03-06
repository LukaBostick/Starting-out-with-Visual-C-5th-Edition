using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array_Argument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an int array.
            int[] numbers = { 1, 2, 3 };
           
            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

            // Pass the array to the SetToZero method.
            SetToZero(numbers);

            // Display the array in the list box again.
            outputListBox.Items.Add("");
            outputListBox.Items.Add("After calling SetToZero:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
        }

        // The SetToZero method accepts an int array as an
        // argument and sets its elememts to 0.
        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
