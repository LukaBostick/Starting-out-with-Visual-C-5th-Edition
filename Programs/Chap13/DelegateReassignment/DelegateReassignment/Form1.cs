using System;
using System.Windows.Forms;

namespace DelegateReassignment
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

        private void button1_Click(object sender, EventArgs e)
        {
            string mystring = "Abracadabra";
            WorksWithAString StringAction = DisplayString;
            StringAction(mystring);
            StringAction = DisplayLength;
            StringAction(mystring);
        }
    }
}
