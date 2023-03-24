namespace _11._RANDOM_NUMBER_GUESS_GAME
{
    public partial class Form1 : Form
    {
       static int rand = new Random().Next() % 100;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(int.Parse(textBox1.Text) > rand)
            {
                label2.Text = "Guess is too high";
            }

            if (int.Parse(textBox1.Text) < rand)
            {
                label2.Text = "Guess is too low";
            }

            if (int.Parse(textBox1.Text) == rand)
            {
                label2.Text = "Congrates you guessed the number!!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}