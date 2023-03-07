namespace _12._PAINT_JOB_ESTIMATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //the number of gallons of paint required

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //the hours of labor requirws
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //the cost of the paint
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // the labor charges
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //The total cost of the paint job.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sqr feet
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //price per gal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //label3.Text = label3.Text.ToString().Substring(17);
           // label4.Text = label4.Text.ToString().Substring(18);
           // label5.Text = label5.Text.ToString().Substring(17);
            //label6.Text = label6.Text.ToString().Substring(13);
            //label10.Text = label10.Text.ToString().Substring(10);

            int gallons = int.Parse(textBox1.Text) / 115;
            int labor = gallons * 20;

            int costPaint =int.Parse(textBox2.Text)*gallons;


            label3.Text += " "+gallons.ToString();
            label4.Text += " "+(8*gallons).ToString();
            label5.Text += " " + costPaint.ToString();
            label6.Text += " "+labor.ToString()+"$";
            label10.Text = " "+(costPaint+labor).ToString()+"$";


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}