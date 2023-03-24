namespace _12._CALCULATING_THE_FACTORIAL_OF_A_NUMBER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "12. CALCULATING THE FACTORIAL OF A NUMBER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userin = int.Parse(textBox1.Text);
            int total = userin;
            for (int i = 1; i < userin; i++)
                total = total * i;
                label2.Text = total.ToString();
        }
    }
}