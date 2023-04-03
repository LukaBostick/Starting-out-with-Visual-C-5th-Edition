namespace _3._KINETIC_ENERGY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            double kilograms = double.Parse(textBox1.Text);

            double velocity = double.Parse(textBox2.Text);

            label5.Text = KineticEnergy(kilograms, velocity).ToString();
        }
        public double KineticEnergy(double kilograms, double velocity)
        {
            return .5 * (kilograms * Math.Pow(velocity, 2));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}