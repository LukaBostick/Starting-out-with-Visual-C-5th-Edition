namespace _5._PENNIES_FOR_PAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "5. PENNIES FOR PAY";
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
            int income = 0;
            int pennys = 0;
            int lcv = int.Parse(textBox1.Text);
            for(int i = 0; i < lcv; i++)
            {
                income += ++pennys;
            }

            label4.Text= income.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}