using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string inpuPath = "C:/Users/masterofdoom/code projects/C#/C Sharp Learning/vehicleList.txt";

            using StreamReader sr = new(inpuPath);
            {
                string lineOfText;
                while ((lineOfText = sr.ReadLine()) != null)
                {
                    string[] licenseAndType = lineOfText.Split(" ");
                    string license = licenseAndType[0];
                    string vehicleType = licenseAndType[1];

                    Console.WriteLine($"The vehicle is a {vehicleType} and it's license plate number is {license}.");
                    Console.WriteLine("Please enter the manufacturer of the vehicle.");
                    string manufacturer = Console.ReadLine();

                    if (vehicleType == "Car")
                    {
                        vehicles.Add(new Car(license, manufacturer));
                    }
                    else if (vehicleType == "Motorbike")
                    {
                        vehicles.Add(new MotorBike(license, manufacturer));
                    }
                }
            }

            foreach (Vehicle j in vehicles)
            {

                Console.WriteLine($"Vehicle type is {j.GetType()}, license plate is {j.licensePlate}, wheels is {j.wheels}, manufacturer is {j.manufacturer}.");
            }

            string outputPath = "C:/Users/masterofdoom/code projects/C#/C Sharp Learning/outputList.txt";
            if (File.Exists(outputPath) == true)
            {
                File.Delete(outputPath);
            }
            using StreamWriter sw = File.AppendText(outputPath);
            {
                foreach (Vehicle j in vehicles)
                {
                    sw.WriteLine($"Type is {j.GetType()} license plate is {j.licensePlate} number of wheels is {j.getWheels()} manufacturer is {j.manufacturer}");
                }
            }
        }
    }
}
