namespace _6._HOSPITAL_CHARGES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "6. Hospital Charges";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = CalcTotalCharges().ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public double CalcStayCharges()
        {
            return double.Parse(textBox1.Text)*350;
        }
        public double CalcMiscCharges()
        {
            return double.Parse(textBox2.Text) + 
                   double.Parse(textBox3.Text) + 
                   double.Parse(textBox4.Text) + 
                   double.Parse(textBox5.Text);
        }
        public double CalcTotalCharges()
        {
            return CalcMiscCharges() + CalcStayCharges();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}