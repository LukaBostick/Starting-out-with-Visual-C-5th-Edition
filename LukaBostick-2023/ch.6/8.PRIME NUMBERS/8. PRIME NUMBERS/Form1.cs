namespace _8._PRIME_NUMBERS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "8. Prime Numners";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = IsPrime(int.Parse(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Boolean IsPrime(int userin)
        {
            for(int i = 1; i < userin; i++) { 

                
                if(userin % i == 0 && i != 1 && i!= userin) { 
                    return false;
                }
                
            }
                return true;
        }
    }
}