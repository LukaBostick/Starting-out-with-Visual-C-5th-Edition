using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ForEachDemo1
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

            // Create an Action delegate that displays an integer.
            Action<int> Display = x => MessageBox.Show(x.ToString());

            // Invoke the Display delegate for each element of the List.
            numbers.ForEach(Display);
        }
    }
}
