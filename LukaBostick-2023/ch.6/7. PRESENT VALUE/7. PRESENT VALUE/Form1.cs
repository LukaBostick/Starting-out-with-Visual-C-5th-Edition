namespace _7._PRESENT_VALUE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "7. PRESENT VALUE";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = (PresentValue(double.Parse(textBox1.Text), double.Parse(textBox4.Text), double.Parse(textBox2.Text))).ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public double PresentValue(double value, double numYears, double intrest)
        {
            return value / (Math.Pow((1 + (intrest*.01f)),numYears));
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}