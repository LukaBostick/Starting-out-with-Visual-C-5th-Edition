namespace HEADS_OR_TAILS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show heads

            pictureBox1.Visible= true;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tails
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }
    }
}