using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Truck_SUV_Demo
{
    class SportUtility : Automobile
    {
        // Constructor
        public SportUtility()
        {
            Passengers = 0;
        }

        // Passengers property
        public int Passengers { get; set; }
    }
}
