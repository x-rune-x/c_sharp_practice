using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    public abstract class Vehicle
    {
        public int wheels;
        public string manufacturer;

        public int getWheels()
        {
            return wheels;
        }

        public abstract string washVehicle();
    }
}
