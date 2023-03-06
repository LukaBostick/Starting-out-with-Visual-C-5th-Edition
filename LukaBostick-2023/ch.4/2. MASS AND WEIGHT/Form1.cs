namespace _2._MASS_AND_WEIGHT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "2. MASS AND WEIGHT";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int postParceUserInt = int.Parse(textBox1.Text);
            //if userint is larger then 1000 or less then 0
            if(postParceUserInt > 1000 || postParceUserInt <0) 
            {
                label3.Text = " Overloaded Please Enter a weight between 0Kg - 1,000Kg";
                
            }
            else
            {
                label3.Text = (postParceUserInt * 9.8).ToString()+"Kg";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}