using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Named_Arguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Shownames method accepts arguments for a first
        // name and a last name. It displays a message box showing
        // the first name followed by a space, followed by the
        // last name.
        private void ShowName(string firstName, string lastName)
        {
            MessageBox.Show(firstName + " " + lastName);
        }

        private void combineButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the first and last names
            string first, last;

            // Get the first and last names from the TextBoxes.
            first = firstNameTextBox.Text;
            last = lastNameTextBox.Text;

            // Combine the names.
            ShowName(lastName: last, firstName: first);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
