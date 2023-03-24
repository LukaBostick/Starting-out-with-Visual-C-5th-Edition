namespace _1._DISTANCE_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Distance Calculator";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acumulator = 0;
            for(int i = 0; i <int.Parse(textBox1.Text); i++)
            {
                int temp = int.Parse(textBox2.Text);
                acumulator+= temp;
                listBox1.Items.Add("After hour "+(i+1)+" the distance is "+acumulator);
            }

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
    }
}