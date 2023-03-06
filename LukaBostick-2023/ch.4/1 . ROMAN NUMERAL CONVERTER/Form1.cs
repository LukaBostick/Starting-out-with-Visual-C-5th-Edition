namespace _1_._ROMAN_NUMERAL_CONVERTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "1. ROMAN NUMERAL CONVERTER";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void RomanNum(String userin)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int postParseUserInput = int.Parse(textBox1.Text);
            //display Numeral
            //test for valid input


            switch (postParseUserInput)
            {

                case 1: { label3.Text = "I"; break; }
                case 2: { label3.Text = "II"; break; }
                case 3: { label3.Text = "III"; break; }
                case 4: { label3.Text = "IV"; break; }
                case 5: { label3.Text = "V"; break; }
                case 6: { label3.Text = "VI"; break; }
                case 7: { label3.Text = "VII"; break; }
                case 8: { label3.Text = "VIII"; break; }
                case 9: { label3.Text = "IX"; break; }
                case 10: { label3.Text = "X"; break; }
            }
        }
    }
}