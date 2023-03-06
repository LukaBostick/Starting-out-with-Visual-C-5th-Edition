using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Race_Times
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double runner1;     // Runner #1's time
            double runner2;     // Runner #2's time
            double runner3;     // Runner #3's time
            double average;     // Average race time.

            // Get the times entered by the user.
            runner1 = double.Parse(runner1TextBox.Text);
            runner2 = double.Parse(runner2TextBox.Text);
            runner3 = double.Parse(runner3TextBox.Text);

            // Calculate the average time (do you see an error?)
            average = runner1 + runner2 + runner3 / 3.0;

            // Display the average time.
            averageTimeLabel.Text = average.ToString("n1");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes.
            runner1TextBox.Text = "";
            runner2TextBox.Text = "";
            runner3TextBox.Text = "";

            // Clear the average race time.
            averageTimeLabel.Text = "";

            // Reset the focus.
            runner1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
