using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    class MotorBike : Vehicle
    {
        public MotorBike(string inputManufacturer)
        {
            wheels = 2;
            manufacturer = inputManufacturer;
        }

        public override string washVehicle()
        {
            var text = "I'm washing the motorbike by hand!";
            return text;
        }
    }
}
