namespace _7._CALORIES_BURNED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            
            for(int i = 10; i < 30; i+=5) {
                
            total += i;
                listBox1.Items.Add("Calories burned after " +i +" Mins = "+ total);
            }
        }
    }
}