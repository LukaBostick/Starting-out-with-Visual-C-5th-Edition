namespace _4._CALORIES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CALORIES FROM FAT AND CARBOHYDRATES";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fat = FatCalories(decimal.Parse(textBox1.Text));

            decimal carbs = CarbCalories(decimal.Parse(textBox2.Text));

            label7.Text = fat.ToString()+ " Calories";
            label2.Text = carbs.ToString()+" Calories";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //calories from fat
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //calories from carbs
        }

        public decimal FatCalories(decimal fat)
        {
            return fat * 9;
        }
        public decimal CarbCalories(decimal carb)
        { 
            return carb * 4;
        }
    }
}