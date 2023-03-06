using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Number_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNumbersButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object.
                outputFile = File.CreateText("Numbers.txt");

                // Write the numbers 1 through 10 to the file.
                for (int count = 1; count <= 10; count++)
                {
                    outputFile.WriteLine(count);
                }

                // Close the file.
                outputFile.Close();
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
