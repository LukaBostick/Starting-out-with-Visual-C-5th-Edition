using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variable to hold the test score.
                double testScore;

                // Get the test score.
                testScore = double.Parse(testScoreTextBox.Text);

                // Determine the grade.
                if (testScore < 60)
                {
                    gradeLabel.Text = "F";
                }
                else if (testScore < 70)
                {
                    gradeLabel.Text = "D";
                }
                else if (testScore < 80)
                {
                    gradeLabel.Text = "C";
                }
                else if (testScore < 90)
                {
                    gradeLabel.Text = "B";
                }
                else
                {
                    gradeLabel.Text = "A";
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
