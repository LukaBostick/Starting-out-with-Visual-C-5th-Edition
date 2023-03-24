namespace _10._ADDITION_TUTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "10. ADDITION TUTOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rand1 = new Random().Next();
            int rand2 = new Random().Next();

            label1.Text = rand1.ToString();
            label3.Text = rand2.ToString();
            label5.Text = (rand1+rand2).ToString();
        }
    }
}