using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                WebBrowser1.Url = new Uri(urlTextBox.Text);
            }
            catch (Exception ex)
            {
                // Error message for an invalid Web address.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
