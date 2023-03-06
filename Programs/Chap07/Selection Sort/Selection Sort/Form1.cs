using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SelectionSort method accepts an int array as an argument.
        // It uses the Selection Sort algorithm to sort the array.
        private void SelectionSort(int[] iArray)
        {
            int minIndex;   // Subscript of smallest value in scanned area
            int minValue;   // Smallest value in the scanned area

            // The outer loop steps through all the array elements,
            // except the last one. The startScan variable marks the
            // position where the scan should begin.
            for (int startScan = 0; startScan < iArray.Length - 1; startScan++)
            {
                // Assume the first element in the scannable area
                // is the smallest value.
                minIndex = startScan;
                minValue = iArray[startScan];

                // Scan the array, starting at the 2nd element in the
                // scannable area, looking for the smallest value.
                for (int index = startScan + 1; index < iArray.Length; index++)
                {
                    if (iArray[index] < minValue)
                    {
                        minValue = iArray[index];
                        minIndex = index;
                    }
                }

                // Swap the element with the smallest value with the
                // first element in the scannable area.
                Swap(ref iArray[minIndex], ref iArray[startScan]);
            }
        }

        // The Swap method accepts two integer arguments, by reference,
        // and swaps their contents.
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an array of integers.
            int[] numbers = { 4, 6, 1, 3, 5, 2 };

            // Display the array in original order.
            foreach (int value in numbers)
            {
                originalListBox.Items.Add(value);
            }

            // Sort the array.
            SelectionSort(numbers);

            // Display the array in sorted order.
            foreach (int value in numbers)
            {
                sortedListBox.Items.Add(value);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
