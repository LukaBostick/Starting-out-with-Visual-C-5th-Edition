namespace _10._FAT_PERCENTAGE_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                decimal fatGrams; 
                decimal totalCal;
                decimal percentCal;
                if(decimal.TryParse(textBox1.Text, out fatGrams))
                {
                    //fat grams now = cal from fat
                    fatGrams = fatGrams / 9;
                    label5.Text = fatGrams.ToString();
                }

                if(decimal.TryParse(textBox2.Text, out totalCal))
                {
                    percentCal = (fatGrams / totalCal);
                        
                        label6.Text = percentCal.ToString("0.00%");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Percentage of calories from fat
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //num fat grams
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //fat grams
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // total cal
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}