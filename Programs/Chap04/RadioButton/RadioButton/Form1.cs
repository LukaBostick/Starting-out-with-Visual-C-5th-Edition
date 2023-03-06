using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (footballRadioButton.Checked)
            {
                MessageBox.Show("You selected Football.");
            }
            else if (basketballRadioButton.Checked)
            {
                MessageBox.Show("You selected Basketball.");
            }
            else if (baseballRadioButton.Checked)
            {
                MessageBox.Show("You selected Baseball.");
            }
        }
    }
}
