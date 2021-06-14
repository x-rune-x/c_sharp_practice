using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    public class Car : Vehicle
    {        
        public Car(string inputLicensePlate, string inputManufacturer)
        {
            licensePlate = "Unknown";
            licensePlate = inputLicensePlate;
            wheels = 4;
            manufacturer = inputManufacturer;
        }

        public string getLicensePlate()
        {
            return licensePlate;
        }

        public override string washVehicle()
        {
            var washText = "I'm going through the car wash";
            return washText;
        }
    }
}
