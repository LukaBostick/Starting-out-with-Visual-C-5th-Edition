using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VScrollBarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vScrollBar.Value = 0;
            vScrollBar.Minimum = 0;
            vScrollBar.Maximum = 100;
            vScrollBar.LargeChange = 10;
            vScrollBar.SmallChange = 1;

            // Display the scroll bar's initial value
            // in the label control.
            valueLabel.Text = vScrollBar.Value.ToString();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Display the scroll bar value.
            valueLabel.Text = vScrollBar.Value.ToString();
        }
    }
}
