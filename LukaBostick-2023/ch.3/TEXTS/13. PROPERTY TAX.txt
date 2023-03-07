namespace _13._PROPERTY_TAX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Text = "13. PROPERTY TAX";
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Decimal.Parse(textBox1.Text)/100) * 0.64m).ToString()+"$";
        }
    }
}