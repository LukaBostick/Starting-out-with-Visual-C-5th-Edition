namespace _11.TIME_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sec;
                int min;
                int hour;
                int day;
                // Cast operator
                string userin = (string)textBox1.Text;

                sec= int.Parse(userin);

                if(sec >= 60)
                {
                    min = sec/60;
                    label3.Text = min.ToString();
                }

                if(sec >= 3600)
                {
                    hour = sec/3600;
                    label3.Text = hour.ToString();
                }

                if (sec >= 86400)
                {
                    day = sec / 86400;
                    label3.Text = day.ToString();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}