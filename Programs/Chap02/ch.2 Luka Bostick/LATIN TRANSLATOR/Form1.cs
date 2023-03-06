namespace LATIN_TRANSLATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //sinister
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("left");

        }
        //medium
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("center");
        }
        //dextor
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("right");
        }
    }
}