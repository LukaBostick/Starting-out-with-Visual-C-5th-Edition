using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Truck_SUV_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createObjectsButton_Click(object sender, EventArgs e)
        {
            // Create a Car object for a used 2001 BMW with 70,000
            // miles, priced at $15,000, with 4 doors.
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "2001";
            myCar.Mileage = 70000;
            myCar.Price = 15000;
            myCar.Doors = 4;

            // Create a Truck object for a used 2002 Toyota
            // pickup with 40,000 miles, priced at $12,000,
            // with four wheel drive.
            Truck myTruck = new Truck();
            myTruck.Make = "Toyota";
            myTruck.Model = "2002";
            myTruck.Mileage = 40000;
            myTruck.Price = 12000;
            myTruck.Drive = "Four Wheel Drive";

            // Create a SportUtility object for a used 2000
            // Volvo with 30,000 miles, priced at $15,500,
            // with a passenger capacity of 5.
            SportUtility mySUV = new SportUtility();
            mySUV.Make = "Volvo";
            mySUV.Model = "2000";
            mySUV.Mileage = 30000;
            mySUV.Price = 15500;
            mySUV.Passengers = 5;

            // Display data about the car.
            MessageBox.Show(myCar.Model + " " + myCar.Make + " with " +
                myCar.Mileage + " miles, priced at " +
                myCar.Price.ToString("c") + ", with " + myCar.Doors +
                " doors.");

            // Display data about the truck.
            MessageBox.Show(myTruck.Model + " " + myTruck.Make + 
                " with " + myTruck.Mileage + " miles, priced at " +
                myTruck.Price.ToString("c") + ", with " + 
                myTruck.Drive);

            // Display data about the SUV.
            MessageBox.Show(mySUV.Model + " " + mySUV.Make + " with " +
                mySUV.Mileage + " miles, priced at " +
                mySUV.Price.ToString("c") + ", with " + mySUV.Passengers +
                " passengers.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
