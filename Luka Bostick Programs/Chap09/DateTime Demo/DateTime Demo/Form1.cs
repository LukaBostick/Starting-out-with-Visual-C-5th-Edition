using System;
using System.Windows.Forms;

namespace DateTime_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Get the date selected by the user.
            DateTime selected = myDateTimePicker.Value;

            // Display the date.
            dateLabel.Text = selected.ToString("F");
        }
    }
}
