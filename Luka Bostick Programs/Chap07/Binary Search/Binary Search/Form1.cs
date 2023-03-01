using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Binary_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SelectionSort method accepts a string array as an argument.
        // It uses the Selection Sort algorithm to sort the array.
        private void SelectionSort(string[] sArray)
        {

            int minIndex;      // Subscript of minimum value in scanned area
            string minValue;   // Minimum value in the scanned area

            // The outer loop steps through all the array elements,
            // except the last one. The startScan variable marks the
            // position where the scan should begin.
            for (int startScan = 0; startScan < sArray.Length - 1; startScan++)
            {
                // Assume the first element in the scannable area
                // is the minimum value.
                minIndex = startScan;
                minValue = sArray[startScan];

                // Scan the array, starting at the 2nd element in the
                // scannable area, looking for the minimum value.
                for (int index = startScan + 1; index < sArray.Length; index++)
                {
                    if (string.Compare(sArray[index], minValue, true) < 0)
                    {
                        minValue = sArray[index];
                        minIndex = index;
                    }
                }

                // Swap the element with the lesser value with the
                // first element in the scannable area.
                Swap(ref sArray[minIndex], ref sArray[startScan]);
            }
        }

        // The Swap method accepts two string arguments, by reference,
        // and swaps their contents.
        private void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        // The BinarySearch method searches for a value in a
        // string array. If the value is found, the method returns
        // its subscript. Otherwise, the method returns -1.
        private int BinarySearch(string[] sArray, string value)
        {
            int first = 0;                // First array element
            int last = sArray.Length - 1; // Last array element
            int middle;                   // Mid point of search
            int position = -1;            // Position of search value
            bool found = false;           // Flag

            // Search for the value.
            while (!found && first <= last)
            {
                // Calculate mid point
                middle = (first + last) / 2;

                // If value is found at midpoint...
                if (string.Compare(sArray[middle], value, true) == 0)
                {
                    found = true;
                    position = middle;
                }
                // else if value is in lower half...
                else if (string.Compare(sArray[middle], value, true) > 0)
                {
                    last = middle - 1;
                }
                // else if value is in upper half....
                else
                {
                    first = middle + 1;
                }
            }

            // Return the position of the item, or -1
            // if it was not found.
            return position;
        }

        // The ReadNames method reads names from a file
        // into the array passed as an argument.
        private void ReadNames(string[] sArray)
        {
            try
            {
                // Counter variable to use in the loop
                int index = 0;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Names.txt");

                // Read the file's contents into the array.
                while (index < sArray.Length && !inputFile.EndOfStream)
                {
                    sArray[index] = inputFile.ReadLine();
                    index++;
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Create an array to hold a list of names.
            const int SIZE = 40;
            string[] names = new string[SIZE];

            // Get the name to search for.
            string searchValue = searchTextBox.Text;

            // Read names from the file into the array.
            ReadNames(names);

            // Sort the names.
            SelectionSort(names);

            // Search for the specifed name.
            if (BinarySearch(names, searchValue) != -1)
            {
                MessageBox.Show(searchValue + " is found in the file.");
            }
            else
            {
                   MessageBox.Show(searchValue + " is not found in the file.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
