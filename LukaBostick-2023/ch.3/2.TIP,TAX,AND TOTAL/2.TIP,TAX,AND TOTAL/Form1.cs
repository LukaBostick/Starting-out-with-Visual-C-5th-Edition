using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.TIP_TAX_AND_TOTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //display 15% tip




    
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //display 7 % tip


        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Display total
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tip, tax,total, userin;

           userin=decimal.Parse(textBox1.Text);

            tip = userin * .15m;
            tax = userin * .07m; 

            total = userin+tip+tax;

            label6.Text=tip.ToString();

            label5.Text = tax.ToString();

            label7.Text = total.ToString();

        }

        
    }
}
