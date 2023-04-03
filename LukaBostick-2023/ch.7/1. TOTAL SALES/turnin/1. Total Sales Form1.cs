using System.IO;

namespace _1._TOTAL_SALES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "1. TOTAL SALES";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fileName = "E:\\Workspace 1-15-2023\\work\\Starting out with Visual C# 5th\\c# main\\Intro_to_Csharp_Pgm_Luka\\LukaBostick-2023\\ch.7\\1. TOTAL SALES\\1. TOTAL SALES\\Sales.txt";
            int sizeOfArry = 0;
            decimal total = 0;
            try
            {

           
            StreamReader inFile = File.OpenText(fileName);

            while(inFile.EndOfStream == false)
            {

                sizeOfArry++;

                total+=decimal.Parse(inFile.ReadLine()+0);

                while (inFile.EndOfStream == false)
                {
                    
                    listBox1.Items.Add(inFile.ReadLine() + " Line num: " + "\n" + sizeOfArry++ + "\n");

                }

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            label3.Text = total.ToString("c");
            //init file array
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}