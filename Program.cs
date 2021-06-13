using System;
using System.IO;
using System.Text;
using System.Collections;

namespace C_Sharp_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new("ABC123", "Jaguar");

            Console.WriteLine(car1.getLicensePlate());
            Console.WriteLine(String.Format("The number of wheels of the car is {0}.", car1.getWheels()));
            Console.WriteLine(car1.washVehicle());
            Console.WriteLine(car1.manufacturer);

            MotorBike mb1 = new("Yamaha");

            Console.WriteLine(mb1.wheels);
            Console.WriteLine(mb1.washVehicle());
            Console.WriteLine(mb1.manufacturer);


        }
    }
}
