using System.Linq;

namespace _7._SENTENCE_BUILDER
{
    public partial class Form1 : Form
    {
        string displaytext = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //(Space

            displaytext += " ";
            button21.Text = " ";
            textBox1.Text = displaytext;   
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //.
            displaytext += ".";
            button22.Text = "!";
            textBox1.Text = displaytext;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //!
            displaytext += "!";
            button23.Text = "!";
            textBox1.Text = displaytext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //dog
            displaytext += "dog";
            button9.Text = "dog";
            textBox1.Text = displaytext;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //laughed at
            displaytext += "laughed at";
            button20.Text = "laughed at";
            textBox1.Text = displaytext;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // spoke to
            displaytext += "spoke to";
            button19.Text = "spoke to";
            textBox1.Text = displaytext;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //rode
            displaytext += "rode";
            button18.Text = " rode";
            textBox1.Text = displaytext;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //looked at
            displaytext += "looked at";
            button17.Text = " looked at";
            textBox1.Text = displaytext;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //strange
            displaytext += "stranger";
            
            button16.Text = "stranger";
            textBox1.Text = displaytext;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //small
            displaytext += "small";
            button15.Text = " small";
            textBox1.Text = displaytext;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //big
            displaytext += "big";
            button14.Text = " big";
            textBox1.Text = displaytext;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //beautiful
            displaytext += "beautiful";
            button13.Text = " beautiful";
            textBox1.Text = displaytext;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //bicyle
            displaytext += "bicyle";
            button12.Text = "Bicyle";
            textBox1.Text = displaytext;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //car
            displaytext += "car";
            button11.Text = "car";
            textBox1.Text = displaytext;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //cat
            displaytext += "cat";
            button10.Text = " cat";
            textBox1.Text = displaytext;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //carriage
            displaytext += "carriage";
            button5.Text = "carriage";
            textBox1.Text = displaytext;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //woman
            displaytext += "woman";
            button8.Text = "woman";
            textBox1.Text = displaytext;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //man
            displaytext += "man";
            button7.Text = "man";
            textBox1.Text = displaytext;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //the
            displaytext += "the";
            button6.Text = "the";
            textBox1.Text = displaytext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //The
            displaytext += "The";
            button5.Text = "The";
            textBox1.Text = displaytext;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //an
            displaytext += "an";
            button4.Text = "An";
            textBox1.Text = displaytext;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AN
            displaytext += "An";
            button3.Text = "An";
            textBox1.Text = displaytext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //a
            displaytext += "a";
            button2.Text = "a";
            textBox1.Text = displaytext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A
            displaytext += "A";
            button1.Text = "A";
            textBox1.Text = displaytext;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Clear
            displaytext = string.Empty;
            textBox1.Text = displaytext;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Exit
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}