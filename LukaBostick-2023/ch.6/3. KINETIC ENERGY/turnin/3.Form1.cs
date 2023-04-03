using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.KINETIC_ENERGY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "3. KINETIC ENERGY";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = KineticEnergy(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }
        public double KineticEnergy(double mass, double velocity)
        {
            double v = Math.Pow(velocity, 2);

            return (mass * v) * .50;
        }
    }
}
