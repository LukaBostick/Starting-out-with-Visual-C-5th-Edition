namespace _3._CELSIUS_TO_FAHERENHEIT_TABLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "3. CELSIUS TO FAHERNHEIT TABLE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 20; i++) {
                string output = "";
                int temp = ((9 / 5) * i) + 32;

                output= i+"C     ~ "+temp+" F ";

                listBox1.Items.Add(output);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}