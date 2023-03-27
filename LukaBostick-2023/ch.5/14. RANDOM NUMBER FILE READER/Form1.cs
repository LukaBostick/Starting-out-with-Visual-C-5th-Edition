namespace _14._RANDOM_NUMBER_FILE_READER
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
            StreamReader inFile = File.OpenText("F:\\Workspace 1-15-2023\\work\\Starting out with Visual C# 5th\\c# main\\Intro_to_Csharp_Pgm_Luka\\LukaBostick-2023\\ch.5\\14. RANDOM NUMBER FILE READER\\Number.txt");

            int linecount = 0;
            while(inFile.EndOfStream == false)
            {
                linecount++;
                listBox1.Items.Add(inFile.ReadLine() + "Line num: " +"\n"+ linecount+"\n");

            }
            inFile.Close();
        }
    }
}