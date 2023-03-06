namespace _8._HOW_MUCH_INSURANCE
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = (decimal.Parse(textBox1.Text) * .8m).ToString()+"$";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}