namespace _8._BODY_MASS_INDEX_PROGRAM_ENHANCEMENT
{
    public partial class Form1 : Form
    {
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

        private void label3_Click(object sender, EventArgs e)
        {
            //WEIGHT
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //BMI
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(textBox1.Text);

            int height = int.Parse(textBox2.Text);

            double bmi = (weight * 703) / Math.Pow(height, 2);

            label4.Text = bmi.ToString();

            if (bmi >= 18.5 && bmi <= 25)
            {
                label3.Text = "Optimal Weight";
            }
            else if (bmi < 18.5)
            {
                label3.Text = "Under Weight";
            }
            else
            {
                label3.Text = "Over Weight";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}