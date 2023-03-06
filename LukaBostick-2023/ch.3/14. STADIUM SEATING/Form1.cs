namespace _14._STADIUM_SEATING
{
    
    public partial class Form1 : Form
    {
    const int CLASS_A = 15;
    const int CLASS_B = 12;
    const int CLASS_C = 9;
        public Form1()
        {
            InitializeComponent();
            Text = "14.STADIUM SEATING";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear

            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calculate revenue

            decimal classA = Decimal.Parse(textBox1.Text)*15;

            decimal classB = Decimal.Parse(textBox2.Text)*12;

            decimal classC = Decimal.Parse(textBox3.Text)*9;

            decimal total = classA+classB+classC;

            textBox7.Text = classA.ToString();
            textBox6.Text = classB.ToString();
            textBox5.Text = classC.ToString();
            textBox4.Text = total.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Class A seats cost $15 each
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Class B seats cost $12 each
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Class C seats cost $9 each
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //total
        }
    }
}