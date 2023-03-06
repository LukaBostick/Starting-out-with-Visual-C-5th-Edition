using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Name_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Add("Chris");
            namesListBox.Items.Add("Alicia");
            namesListBox.Items.Add("Justin");
            namesListBox.Items.Add("Holly");
        }
    }
}
