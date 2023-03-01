using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_Argument
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The DisplayAuto method accepts an Automobile
        // object as an argument and displays its fields.
        private void DisplayAuto(Automobile auto)
        {
            MessageBox.Show(auto.year + " " + auto.make +
                " with " + auto.mileage + " miles.");
        }

        private void auto1Button_Click(object sender, EventArgs e)
        {
            // Create an instance of the Automobile structure.
            Automobile sportsCar = new Automobile();
            
            // Assign values to the object's fields.
            sportsCar.make = "Chevy Corvette";
            sportsCar.year = 1970;
            sportsCar.mileage = 50000.0;

            // Display the object's fields.
            DisplayAuto(sportsCar);
        }

        private void auto2Button_Click(object sender, EventArgs e)
        {
            // Create an instance of the Automobile structure.
            Automobile pickupTruck = new Automobile();
            
            // Assign values to the object's fields.
            pickupTruck.make = "Ford Ranger";
            pickupTruck.year = 1985;
            pickupTruck.mileage = 75000.0;

            // Display the object's fields.
            DisplayAuto(pickupTruck);
        }

        private void auto3Button_Click(object sender, EventArgs e)
        {
            // Create an instance of the Automobile structure.
            Automobile sedan = new Automobile();

            // Assign values to the object's fields.
            sedan.make = "Honda Accord";
            sedan.year = 2000;
            sedan.mileage = 80000.0;
             
            // Display the object's fields.
            DisplayAuto(sedan);
        }
    }
}
