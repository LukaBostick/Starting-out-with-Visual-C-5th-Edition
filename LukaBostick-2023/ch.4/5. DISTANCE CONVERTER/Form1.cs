namespace _5._DISTANCE_CONVERTER
{
    public partial class Form1 : Form
    {
        enum var
        {
            Inches,
            Feet,
            Yards
        }
        public Form1()
        {
            InitializeComponent();

            this.Text = "Distance Converter";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int convertedDistance = 0;
            try{
                string selectedString1, selectedString2;
            int userin = int.Parse(textBox1.Text);

            // Read the selected items from both list boxes
           selectedString1 = listBox1.SelectedItem.ToString();

           selectedString2 = listBox2.SelectedItem.ToString();

                // all the if statements test both listboxes

                // if both selected items are the same
                if(selectedString1== selectedString2)
                    convertedDistance= userin;

                // Inches to feet
                if (selectedString1 == var.Inches.ToString()&& selectedString2 == var.Feet.ToString() ||
                    selectedString2 == var.Inches.ToString() && selectedString1 == var.Feet.ToString())
                    convertedDistance = userin / 12;


                // Inches to Yards
                if (selectedString1 == var.Inches.ToString() && selectedString2 == var.Yards.ToString() ||
                    selectedString2 == var.Inches.ToString() && selectedString1 == var.Yards.ToString())
                    convertedDistance = userin/36;


                // feet to Inches
                if (selectedString1 == var.Feet.ToString() && selectedString2 == var.Inches.ToString() ||
                    selectedString2 == var.Feet.ToString() && selectedString1 == var.Inches.ToString())
                    convertedDistance = userin * 12;


                // feet to yards
                if (selectedString1 == var.Feet.ToString() && selectedString2 == var.Yards.ToString() ||
                    selectedString2 == var.Feet.ToString() && selectedString1 == var.Yards.ToString())
                    convertedDistance = userin/3;


                //  yards to inches
                if (selectedString1 == var.Yards.ToString() && selectedString2 == var.Inches.ToString()||
                    selectedString2 == var.Yards.ToString() && selectedString1 == var.Inches.ToString())
                    convertedDistance = userin * 36;

                // yards to Feet
                if (selectedString1 == var.Feet.ToString() && selectedString2 == var.Yards.ToString() ||
                    selectedString2 == var.Feet.ToString() && selectedString1 == var.Yards.ToString())
                    convertedDistance = userin*3;


                textBox2.Text= convertedDistance.ToString();
            }catch(Exception ex)
            {
                textBox2.Text = "ERROR";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}