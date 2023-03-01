using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Dealer
{
    public partial class Form1 : Form
    {
        // Dictionary to simulate a deck of cards
        private Dictionary<string, int> deck = new Dictionary<string, int>()
        {
            // Spades
            {"Ace of Spades",1}, {"2 of Spades",2}, {"3 of Spades",3},
            {"4 of Spades",4}, {"5 of Spades",5}, {"6 of Spades",6},
            {"7 of Spades",7}, {"8 of Spades",8}, {"9 of Spades",9},
            {"10 of Spades",10}, {"Jack of Spades",10}, {"Queen of Spades",10},
            {"King of Spades", 10},

            // Hearts
            {"Ace of Hearts",1}, {"2 of Hearts",2}, {"3 of Hearts",3},
            {"4 of Hearts",4}, {"5 of Hearts",5}, {"6 of Hearts",6},
            {"7 of Hearts",7}, {"8 of Hearts",8}, {"9 of Hearts",9},
            {"10 of Hearts",10}, {"Jack of Hearts",10}, {"Queen of Hearts",10},
            {"King of Hearts", 10},

            // Clubs
            {"Ace of Clubs",1}, {"2 of Clubs",2}, {"3 of Clubs",3},
            {"4 of Clubs",4}, {"5 of Clubs",5}, {"6 of Clubs",6},
            {"7 of Clubs",7}, {"8 of Clubs",8}, {"9 of Clubs",9},
            {"10 of Clubs",10}, {"Jack of Clubs",10}, {"Queen of Clubs",10},
            {"King of Clubs", 10},

            // Diamonds
            {"Ace of Diamonds",1}, {"2 of Diamonds",2}, {"3 of Diamonds",3},
            {"4 of Diamonds",4}, {"5 of Diamonds",5}, {"6 of Diamonds",6},
            {"7 of Diamonds",7}, {"8 of Diamonds",8}, {"9 of Diamonds",9},
            {"10 of Diamonds",10}, {"Jack of Diamonds",10}, {"Queen of Diamonds",10},
            {"King of Diamonds", 10}
        };

        public Form1()
        {
            InitializeComponent();
        }
    }
}
