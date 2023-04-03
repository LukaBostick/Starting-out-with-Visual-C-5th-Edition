using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.RETALI_PRICE_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public decimal CalculateRetail(decimal wholesaleCost, decimal markup)
        {
            return wholesaleCost+(wholesaleCost * markup/100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = CalculateRetail(decimal.Parse(textBox1.Text), decimal.Parse(textBox2.Text)).ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
