namespace _8._TUITION_INCREASE
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
           double total = 6000;
            for(int i = 1; i <= 10; i++) { 
            
                total += (total/i)*0.01f;
                listBox1.Items.Add("Tuition ~ " +total+ "$");
            }

        }
    }
}