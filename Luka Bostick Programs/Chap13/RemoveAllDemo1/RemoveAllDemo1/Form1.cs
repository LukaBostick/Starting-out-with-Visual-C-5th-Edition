using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RemoveAllDemo1
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
            List<int> numbers = new List<int>() { -3, -2, -1, 0, 1, 2 };

            // Remove all the elements containing a negative value.
            numbers.RemoveAll(x => x < 0);

            // Display each element of the List.
            numbers.ForEach(x => MessageBox.Show(x.ToString()));
        }
    }
}
