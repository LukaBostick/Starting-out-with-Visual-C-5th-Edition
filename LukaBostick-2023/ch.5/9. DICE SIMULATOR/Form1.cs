namespace _9._DICE_SIMULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random = new Random().Next()%6;


            switch (random)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.Die1;
                    break;
                    case 1:
                    pictureBox1.Image = Properties.Resources.Die2;
                    break;
                    case 2:
                    pictureBox1.Image = Properties.Resources.Die3;
                    break;
                    case 3:
                    pictureBox1.Image = Properties.Resources.Die4;
                    break;
                    case 4:
                    pictureBox1.Image = Properties.Resources.Die5;
                    break;
                    case 5:
                    pictureBox1.Image = Properties.Resources.Die6;
                    break;
            }
            int random2 = new Random().Next()%6;
            
            switch (random2)
            {
                case 0:
                    pictureBox2.Image = Properties.Resources.Die1;
                    break;
                case 1:
                    pictureBox2.Image = Properties.Resources.Die2;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Die3;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Die4;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Die5;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Die6;
                    break;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}