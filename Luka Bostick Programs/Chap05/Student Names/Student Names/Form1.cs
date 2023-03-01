using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Student_Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayNamesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // A variable to hold an item read from the file
                string studentName;

                // A StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Students.txt");

                // Read and display the first name.
                studentName = inputFile.ReadLine();
                MessageBox.Show(studentName);

                // Read and display the second name.
                studentName = inputFile.ReadLine();
                MessageBox.Show(studentName);

                // Read and display the third name.
                studentName = inputFile.ReadLine();
                MessageBox.Show(studentName);

                // Read and display the fourth name.
                studentName = inputFile.ReadLine();
                MessageBox.Show(studentName);

                // Close the file.
                inputFile.Close();
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
