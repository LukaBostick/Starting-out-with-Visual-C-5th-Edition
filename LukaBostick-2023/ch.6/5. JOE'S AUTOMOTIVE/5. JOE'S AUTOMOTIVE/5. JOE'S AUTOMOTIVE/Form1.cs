using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.JOE_S_AUTOMOTIVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Total Fees
            textBox1.Text = TotalCharges().ToString("c");
            // Tax on parts
            textBox4.Text = TaxCharges().ToString("c");
            //Parts with tax
            textBox3.Text= (TaxCharges()+ decimal.Parse(textBox5.Text)).ToString("c");
            // Service and Labor
            textBox2.Text = (OilLubeCharges()+ FlushCharges()+MiscCharges()+ OtherCharges()+ decimal.Parse(textBox6.Text)).ToString("c");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        public decimal OilLubeCharges()
        {
            decimal result = 0;

            if (checkBox6.Checked)
                result+=26;
            if (checkBox7.Checked)
                result+=18;

            return result;
        }

        public decimal FlushCharges()
        {
            decimal result = 0;

            if (checkBox4.Checked)
                result += 30;
            if (checkBox5.Checked)
                result += 80;

            return result;
        }
        public decimal MiscCharges()
        {
            decimal result = 0;

            if (checkBox1.Checked)
                result += 15;
            if (checkBox2.Checked)
                result += 100;
            if(checkBox3.Checked)
                result+= 20;

            return result;
        }
        public decimal OtherCharges()
        {
            decimal result = 0;
            result += decimal.Parse(textBox5.Text);
            result += decimal.Parse(textBox6.Text);

            return result;
        }
        public decimal TaxCharges()
        {
            decimal result = 0;
            result = decimal.Parse(textBox5.Text)*(6/100);
            
            return result;
        }
        public decimal TotalCharges()
        {
            decimal result = 0;
            result = TaxCharges()+OtherCharges()
                +MiscCharges()+FlushCharges()
                +OilLubeCharges();

            return result;
        }

        public void ClearOilLube()
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }
        public void ClearFlushes()
        {
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }
        public void ClearMisc()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        public void ClearOther()
        {
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
        public void ClearFees()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
