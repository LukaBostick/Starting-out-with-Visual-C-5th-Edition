using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field_Demo
{
    public partial class Form1 : Form
    {
        // Declare a private field to hold a name.
        private string name = "Charles";

        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }

        private void chrisButton_Click(object sender, EventArgs e)
        {
            name = "Chris";
        }

        private void carmenButton_Click(object sender, EventArgs e)
        {
            name = "Carmen";
        }
    }
}
