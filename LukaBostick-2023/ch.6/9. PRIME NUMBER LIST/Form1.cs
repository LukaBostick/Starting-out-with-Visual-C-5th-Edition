namespace _9._PRIME_NUMBER_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PRIME NUMBER LIST";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean isPrime(int num)
        {
            for(int i = 1; i < num; i++ )
            {
                if( num % i == 0&& i!=1 && i!=num)
                    return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
               if(isPrime(i))
                listBox1.Items.Add(i.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}