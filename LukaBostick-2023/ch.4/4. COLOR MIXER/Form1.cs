namespace _4._Color_MIXER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                this.BackColor=Color.Red;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     //red                   //yellow                //red                  //yellow
            if (radioButton1.Checked && radioButton5.Checked || radioButton2.Checked && radioButton6.Checked)
            {
                this.BackColor = Color.Purple;
            }
                     //red                   //yellow                //red                  //yellow
            if (radioButton1.Checked && radioButton4.Checked || radioButton3.Checked && radioButton6.Checked)
            {
                this.BackColor = Color.Orange;
            }

                    //blue                  //yellow                  //blue               //yellow
            if (radioButton2.Checked && radioButton4.Checked || radioButton3.Checked && radioButton5.Checked)
            {
                this.BackColor = Color.Green;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                this.BackColor = Color.Red;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}