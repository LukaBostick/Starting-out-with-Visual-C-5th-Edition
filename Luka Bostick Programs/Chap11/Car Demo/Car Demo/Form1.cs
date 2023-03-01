using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetCarData method accepts a Car object as an
        // argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetCarData(Car car)
        {
            // Temporary variables to hold mileage, price,
            // and number of doors
            int mileage;
            decimal price;
            int doors;

            // Get the car's make.
            car.Make = makeTextBox.Text;

            // Get the car's model.
            car.Model = modelTextBox.Text;

            // Get the car's mileage.
            if (int.TryParse(mileageTextBox.Text, out mileage))
            {
                car.Mileage = mileage;

                // Get the car's price.
                if (decimal.TryParse(priceTextBox.Text, out price))
                {
                    car.Price = price;

                    // Get the number of doors.
                    if (int.TryParse(doorsTextBox.Text, out doors))
                    {
                        car.Doors = doors;
                    }
                    else
                    {
                        // Display an error message.
                        MessageBox.Show("Invalid number of doors");
                    }
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("Invalid price");
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid mileage");
            }
        }
        
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a Car object.
            Car myCar = new Car();

            // Get the car data.
            GetCarData(myCar);

            // Display the car data.
            makeLabel.Text = myCar.Make;
            modelLabel.Text = myCar.Model;
            mileageLabel.Text = myCar.Mileage.ToString();
            priceLabel.Text = myCar.Price.ToString("c");
            doorsLabel.Text = myCar.Doors.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
