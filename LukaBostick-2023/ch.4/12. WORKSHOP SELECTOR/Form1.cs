namespace _12._WORKSHOP_SELECTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            int accumulator = 0;
            int locationIndex = int.Parse(textBox1.Text);
            int workshopIndex = int.Parse(textBox3.Text);
            switch (locationIndex)
            {
                case 1:
                    accumulator = 150;
                    break;
                case 2:
                    accumulator = 225;
                    break;
                case 3:
                    accumulator = 175;
                    break;
                case 4:
                    accumulator = 300;
                    break;
                case 5:
                    accumulator = 175;
                    break;
                case 6:
                    accumulator = 150;
                    break;

                    {

                    }
            }
            switch (workshopIndex)
            {
                case 1:
                    total = (accumulator * 3) + 1000;
                    break;
                case 2:
                    total = (accumulator * 3) + 800;
                    break;
                case 3:
                    total = (accumulator * 3) + 1500;
                    break;
                case 4:
                    total = (accumulator * 5) + 1300;
                    break;
                case 5:
                    total = accumulator + 500;
                    break;
            }
            label4.Text = total.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }