using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_By_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SetToZero method accepts an int argument
        // by reference and sets it to zero.
        private void SetToZero(ref int number)
        {
            number = 0;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Declare some local int variables.
            int x = 99, y = 100, z = 101;

            // Display the values in those variables.
            outputListBox.Items.Clear();
            outputListBox.Items.Add("x is set to " + x);
            outputListBox.Items.Add("y is set to " + y);
            outputListBox.Items.Add("z is set to " + z);

            // Pass each variable to SetToZero.
            SetToZero(ref x);
            SetToZero(ref y);
            SetToZero(ref z);

            // Display the values in those variables again.
            outputListBox.Items.Add("--------------------");
            outputListBox.Items.Add("x is set to " + x);
            outputListBox.Items.Add("y is set to " + y);
            outputListBox.Items.Add("z is set to " + z);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
