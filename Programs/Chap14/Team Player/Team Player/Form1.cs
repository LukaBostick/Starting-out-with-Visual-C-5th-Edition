using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Player
{
    public partial class Form1 : Form
    {
        // Baseball team members
        List<string> baseball = new List<string>()
        {
            "Jodi", "Carmen", "Alicia", "Aida"
        };

        // Basketball team members
        List<string> basketball = new List<string>()
        {
            "Eva", "Carmen", "Alicia", "Sarah"
        };

        public Form1()
        {
            InitializeComponent();
        }
    }
}
