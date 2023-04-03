namespace Falling_Distance
{
    public partial class Form1 : Form
    {
        const double G = 9.8;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double userin = FallingDistance(int.Parse(textBox1.Text));
            label4.Text = userin.ToString();

        }
        public double FallingDistance(int sec)
        {

            return .5 * (G * Math.Pow(sec, 2));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}