using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastDelegate
{
    delegate void WorksWithAString(string str);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayString(string str)
        {
            MessageBox.Show(str);
        }

        private void DisplayLength(string str)
        {
            int len = str.Length;
            MessageBox.Show(len.ToString());
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            // Create a string.
            string mystring = "Abracadabra";

            // Create a delegate referencing the DisplayString method.
            WorksWithAString StringAction = DisplayString;

            // Add the DisplayLength method to the delegate.
            StringAction += DisplayLength;

            // Call the methods that StringAction references.
            StringAction(mystring);
        }
    }
}
