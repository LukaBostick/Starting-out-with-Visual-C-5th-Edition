namespace Name_Formatter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String first = "", middle = "", last = "", title = "";

            first = textBox1.Text;
            middle = textBox2.Text;
            last = textBox3.Text;
            title = textBox4.Text;

           label5.Text = title+" " +first + " "+middle+" " + last
                         + "\n"+
                          first + " " + middle + " " + last
                         + "\n" +
                         first  + " " + last
                         + "\n" +
                        last +", "+ first + " " + middle + ", " + title
                         + "\n" +
                         last+", "+first+" "+middle
                         + "\n" +
                        last +", "+first
                         + "\n" 
                         ;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //f
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //m
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //l
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //t
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}