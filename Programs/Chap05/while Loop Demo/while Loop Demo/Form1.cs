using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace while_Loop_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to count the loop iterations.
            int count = 1;

            // Display "Hello" in a message box five times.
            while (count <= 5)
            {
                // Display the message box.
                MessageBox.Show("Hello");

                // Add one to count.
                count = count + 1;
            }
        }
    }
}
