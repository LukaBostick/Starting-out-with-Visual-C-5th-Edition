using System;
using System.Windows.Forms;

namespace LambdaDemo2
{
    delegate int IntCalculator(int a, int b);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            int result;
            IntCalculator Sum = (a, b) => a + b;
            IntCalculator Multiply = (a, b) => a * b;

            result = Sum(1, 2);
            MessageBox.Show("1 + 2 =  " + result.ToString());

            result = Multiply(2, 4);
            MessageBox.Show("2 * 4 =  " + result.ToString());
        }
    }
}
