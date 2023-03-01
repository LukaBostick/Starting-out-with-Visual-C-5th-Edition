using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Roster
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>()
        {
            new Student("Adams", "Susan"),
            new Student("Adams", "James"),
            new Student("Watson", "Earl"),
            new Student("Lee", "Tina"),
            new Student("Lee", "Austin"),
            new Student("Brooks", "Gary"),
            new Student("Brooks", "Lisa"),
            new Student("Campbell", "Patrick"),
            new Student("Gonzalez", "Annie"),
            new Student("Anderson", "Ashley"),
        };

        public Form1()
        {
            InitializeComponent();
        }
    }
}
