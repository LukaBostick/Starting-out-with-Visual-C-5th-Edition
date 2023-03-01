using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ForEachDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            // Create a list of integers.
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // Display each element of the List.
            numbers.ForEach(x => MessageBox.Show(x.ToString()));
        }
    }
}
