namespace _4._POPULATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startingOrg = double.Parse(textBox1.Text);
            int lcv = int.Parse(textBox3.Text);

            double average = (double.Parse(textBox2.Text)/lcv)*0.0f;

            for(int i = 0; i < lcv; i++)
            {
                startingOrg += average;
                listBox1.Items.Add((i+1)+"    ~"+startingOrg);
            }
        }
    }
}