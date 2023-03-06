using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQtoArray1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getValuesButton_Click(object sender, EventArgs e)
        {
            int[] numbers = { 4, 104, 2, 102, 1, 101, 3, 103 };

            var results = from item in numbers
                          where item > 100
                          select item;

            foreach (var value in results)
            {
                resultsListBox.Items.Add(value);
            }
        }
    }
}
