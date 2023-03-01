using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the goButton_Click method.");
            DisplayMessage();
            MessageBox.Show("Back in the goButton_Click method.");
        }

        private void DisplayMessage()
        {
            MessageBox.Show("This is the DisplayMessage method.");
        }
    }
}
