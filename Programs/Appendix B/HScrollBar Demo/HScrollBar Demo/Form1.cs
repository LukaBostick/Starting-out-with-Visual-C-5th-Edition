using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HScrollBar_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar.Value = 0;
            hScrollBar.Minimum = 0;
            hScrollBar.Maximum = 100;
            hScrollBar.LargeChange = 10;
            hScrollBar.SmallChange = 1;

            // Display the scroll bar's initial value
            // in the label control.
            valueLabel.Text = hScrollBar.Value.ToString();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Display the scroll bar value.
            valueLabel.Text = hScrollBar.Value.ToString();
        }
    }
}
