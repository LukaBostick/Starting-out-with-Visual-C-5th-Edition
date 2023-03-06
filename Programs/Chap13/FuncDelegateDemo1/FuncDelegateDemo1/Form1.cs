using System;
using System.Windows.Forms;

namespace FuncDelegateDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            Func<int, double> Half = x => x * 0.5;
            double result = Half(25);

            MessageBox.Show("Half of 25 is " + result.ToString());
        }
    }
}
