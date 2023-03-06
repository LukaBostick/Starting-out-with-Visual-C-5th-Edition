namespace ORION_CONSTELLATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide Star names

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show Star Names

            //init objs in method

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Betelgause
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Meissa
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Mintaka
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Alnilam
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Alnitak
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Saliph
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Rigel
        }
    }
}