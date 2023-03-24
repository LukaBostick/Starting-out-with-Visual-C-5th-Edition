namespace _7._SOFTWARE_SALES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int userin = int.Parse(textBox1.Text);

            if(userin >= 10 && userin < 19)
            {
                label6.Text =  ((userin * 99)-(99*.2f)).ToString();
                label5.Text = "20%";
            }

            if (userin >= 20 && userin < 49)
            {
                label6.Text = ((userin * 99) - (99 * .3f)).ToString();
                label5.Text = "30%";
            }

            if (userin >= 50 && userin < 99)
            {
                label6.Text = ((userin * 99) - (99 * .4f)).ToString();
                label5.Text = "40%";
            }

            if (userin >= 100)
            {
                label6.Text = ((userin * 99) - (99 * .5f)).ToString();
                label5.Text = "50%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}