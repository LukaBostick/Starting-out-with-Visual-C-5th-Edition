using System;
using System.Windows.Forms;

namespace LambdaDemo
{
    delegate int IntOperation(int x);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            int result;
            IntOperation Square = x => x * x;
            
            result = Square(5);
            MessageBox.Show("5 squared is  " + result.ToString());
        }
    }
}
