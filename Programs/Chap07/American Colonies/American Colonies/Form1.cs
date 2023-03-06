using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace American_Colonies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SequentialSearch method searches a string array
        // for a specified value. If the value is found, its
        // position is returned. Otherwise, -1 is returned.
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;  // Flag indicating search results
            int index = 0;       // Used to step through the array
            int position = -1;   // Position of value, if found

            // Search the array.
            while (!found && index < sArray.Length)
            {
                if (sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            // Return 
            return position;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string selection;   // To hold the user's selection

            // Create an array with the colony names.
            string[] colonies = {  "Delaware", "Pennsylvania", "New Jersey",
                                    "Georgia", "Connecticut", "Massachusetts",
                                    "Maryland", "South Carolina", "New Hampshire",
                                    "Virginia", "New York", "North Carolina", 
                                    "Rhode Island" };

            if (selectionListBox.SelectedIndex != -1)
            {
                // Get the selected item.
                selection = selectionListBox.SelectedItem.ToString();

                // Determine if the item is in the array.
                if (SequentialSearch(colonies, selection) != -1)
                {
                    MessageBox.Show("Yes, that was one of the colonies.");
                }
                else
                {
                    MessageBox.Show("No, that was not one of the colonies.");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
