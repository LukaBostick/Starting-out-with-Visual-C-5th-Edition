namespace _6._BOOK_CLUB_POINTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "6. BOOK CLUB POINTS";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userin = int.Parse(textBox1.Text);
                int points = 0;

                switch(userin)
                {
                    case 0:
                        break;
                    
                    case 1:
                        points = 5;
                        break;
                    
                    case 2:
                        points = 15;
                        break;
                    
                    
                    case 3:
                        points = 30;
                        break;
                   
                    case 4:
                        points = 60;
                        break;

                    default: 
                        if(userin > 4)
                            points = 60;
                        break;
                }

                label4.Text = points.ToString();
            }catch(Exception ex)
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}