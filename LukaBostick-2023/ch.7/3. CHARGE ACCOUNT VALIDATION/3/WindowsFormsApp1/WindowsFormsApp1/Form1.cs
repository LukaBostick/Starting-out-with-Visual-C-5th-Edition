using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "3. CHARGE ACCOUNT VALIDATION";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                const int Size = 18;

                int[] accounts = new int[Size];

                StreamReader inputFile;
                inputFile = File.OpenText("C:\\Users\\lukab\\Dropbox\\PC\\Desktop\\                    FUUUUUCK\\github\\Intro_to_Csharp_Pgm_Luka\\LukaBostick-2023\\ch.7\\3. CHARGE ACCOUNT VALIDATION\\3\\WindowsFormsApp1\\WindowsFormsApp1\\ChargeAccounts.txt");


                while (index < accounts.Length && !inputFile.EndOfStream)
                {
                    accounts[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // account validation 
                foreach (int acc in accounts)
                {
                    if (int.Parse(textBox1.Text) == acc)
                    {
                        label1.Text = "Password Validated";
                        return;
                    }
                }

                label1.Text = "Password not Validated";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
