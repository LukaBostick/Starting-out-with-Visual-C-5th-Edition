using System;
using System.Windows.Forms;

namespace HighestLowest
{
    delegate bool CompareMethod(int a, int b);

    public partial class Form1 : Form
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

        public Form1()
        {
            InitializeComponent();
        }

        // The isGreater method returns true if a is
        // greater than b. Otherwise it returns false.
        private bool IsGreater(int a, int b)
        {
            if (a > b)
                return true;
            else
                return false;
        }

        // The isLess method returns true if a is
        // less than b. Otherwise it returns false.
        private bool IsLess(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

        private int FindTopOrBottom(int[] array, CompareMethod comp)
        {
            int temp = array[0];

            for (int index = 1; index < array.Length; index++)
            {
                if (comp(array[index], temp))
                {
                    temp = array[index];
                }
            }
            return temp;
        }

        private void highestButton_Click(object sender, EventArgs e)
        {
            CompareMethod GTCompare = IsGreater;
            int highest = FindTopOrBottom(numbers, GTCompare);
            MessageBox.Show(highest.ToString());
        }

        private void lowestButton_Click(object sender, EventArgs e)
        {
            CompareMethod LTCompare = IsLess;
            int lowest = FindTopOrBottom(numbers, LTCompare);
            MessageBox.Show(lowest.ToString());
        }
    }
}
