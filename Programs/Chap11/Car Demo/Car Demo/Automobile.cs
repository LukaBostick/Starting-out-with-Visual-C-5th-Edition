using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Demo
{
    class Automobile
    {
        // Constructor
        public Automobile()
        {
            Make = "";
            Model = "";
            Mileage = 0;
            Price = 0m;
        }

        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}
