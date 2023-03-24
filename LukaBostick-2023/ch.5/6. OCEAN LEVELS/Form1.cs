namespace _6._OCEAN_LEVELS
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int lcv = int.Parse(textBox1.Text);
                double total = 0;

                for (int i = 0; i < lcv; i++)
                {
                    total += 1.5;
                }
                label1.Text = total.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}