using System;
using System.Windows.Forms;

namespace LambdaPassingDemo
{
    delegate void IntRefOperation(ref int x);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrayStepper(int[] array, IntRefOperation op)
        {
            for (int index = 0; index < array.Length; index++)
            {
                op(ref array[index]);
            }
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            // Create an int array with 4 elements.
            int[] numbers = { 10, 20, 30, 40 };

            // Display the contents of the array.
            ArrayStepper(numbers, (ref int x) => MessageBox.Show(x.ToString()));

            // Set each array element to 0.
            ArrayStepper(numbers, (ref int x) => x = 0);

            // Display the contents of the array.
            ArrayStepper(numbers, (ref int x) => MessageBox.Show(x.ToString()));
        }
    }
}
