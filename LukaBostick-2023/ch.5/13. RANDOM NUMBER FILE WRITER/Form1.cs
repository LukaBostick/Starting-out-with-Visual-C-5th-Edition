namespace _13._RANDOM_NUMBER_FILE_WRITER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int lcv = int.Parse(textBox1.Text);
                StreamWriter outputfile;

                outputfile = File.CreateText("Number.txt");
                for(int i = 0; i < lcv; i++)
                {
                    int randnum = new Random().Next() % 100;
                    outputfile.WriteLine(randnum);
                   
                }
                outputfile.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}