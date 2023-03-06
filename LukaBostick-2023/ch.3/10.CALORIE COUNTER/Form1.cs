namespace _10.CALORIE_COUNTER
{
    public partial class Form1 : Form
    {
        static int cal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //90
            cal += 90;
            textBox1.Text= cal.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //80
            cal += 80;
            textBox1.Text = cal.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //115
            cal += 115;
            textBox1.Text = cal.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //120
            cal += 120;
            textBox1.Text = cal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cal = 0;
            textBox1.Text = cal.ToString();
        }
    }
}