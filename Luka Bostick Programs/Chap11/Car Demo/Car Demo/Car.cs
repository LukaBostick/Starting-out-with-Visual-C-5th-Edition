using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Demo
{
    class Car : Automobile
    {
        // Constructor
        public Car()
        {
            Doors = 0;
        }

        // Doors property
        public int Doors { get; set; }
    }
}
