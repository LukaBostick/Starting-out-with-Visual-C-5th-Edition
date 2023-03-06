using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Truck_SUV_Demo
{
    class Truck : Automobile
    {
        // Constructor
        public Truck()
        {
            Drive = "";
        }

        // Drive property
        public string Drive { get; set; }
    }
}
