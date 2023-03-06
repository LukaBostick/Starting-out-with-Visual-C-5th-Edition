using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The FullName method accepts arguments for a first
        // name, a middle name, and a last name. It returns
        // the full name.
        private string FullName(string first, string middle, string last)
        {
            return first + " " + middle + " " + last;
        }

        private void showFullNameButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the first, middle, last, and full names
            string first, middle, last, full;

            // Get the first, middle, and last names.
            first = firstNameTextBox.Text;
            middle = middleNameTextBox.Text;
            last = lastNameTextBox.Text;

            // Get the full name.
            full = FullName(first, middle, last);

            // Display the full name.
            fullNameLabel.Text = full;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
