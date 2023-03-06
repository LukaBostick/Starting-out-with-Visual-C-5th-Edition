namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //joker

            label1.Text = "The Joker";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ace
            label1.Text = "The Ace of Spades";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //king
            label1.Text = "The King of Spades";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //queen
            label1.Text = "The Joker";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //jack
            label1.Text = "The Jack of Spades";
        }
    }
}