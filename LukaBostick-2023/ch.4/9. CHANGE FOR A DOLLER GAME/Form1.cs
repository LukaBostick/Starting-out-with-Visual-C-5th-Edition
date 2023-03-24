namespace _9._CHANGE_FOR_A_DOLLER_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Change For a Doller Game";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int total = 0;
            // find if coins add to a doller
            
          total = int.Parse(textBox1.Text) * 25 +
                (int.Parse(textBox2.Text)) * 10 +
                (int.Parse(textBox3.Text)) *5 +
                (int.Parse(textBox4.Text));

            MessageBox.Show(total.ToString());
            if (total == 100)
                label6.Text = "Congrates you made a doller!! ";
            else
            label6.Text = "Try once more ";
           } 
            

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //pennies
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Nickles
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //dimes
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Quartes
        }
    }
}