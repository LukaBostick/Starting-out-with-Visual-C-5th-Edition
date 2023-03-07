namespace JOKE_AND_PUNCH_LINE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //joke
            label1.Text = "What's a computer"+"\n"+ "scientist's favourite type of coffee?";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PUNCH Line
            label1.Text = "JAVA :3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}