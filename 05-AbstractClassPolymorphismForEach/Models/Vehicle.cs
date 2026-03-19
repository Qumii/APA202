using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }
        public int MaxSpeed { get; set; }


        public Vehicle(string brand, string model, int year, string plateNumber, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            PlateNumber = plateNumber;
            FuelLevel = 100;
            MaxSpeed = maxSpeed;
        }


        public string GetVehicleInfo()
        {
            return $"Marka:{Brand}, Model:{Model}, Il:{Year}, Seriya:{PlateNumber}, Maksimum suret:{MaxSpeed} km/s";
        }
        public void ShowBasicInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
        public abstract double CalculateFuelCost(double distance);

    }
}
