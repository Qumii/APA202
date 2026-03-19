using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }

        public Truck(string brand, string model, int year, string plateNumber, int maxSpeed, double cargoCapacity, int axleCount, double currentLoad) : base(brand, model, year, plateNumber, maxSpeed)
        {
            CargoCapacity = cargoCapacity;
            AxleCount = axleCount;
            CurrentLoad = currentLoad;
        }


        public void ShowTruckInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Yuk tutumu:{CargoCapacity} ton, Ox sayi:{AxleCount}, Cari yuk:{CurrentLoad} ton");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                Console.WriteLine($"{weight} ton yuk elave edildi");
            }
            else
            {
                Console.WriteLine("Yuk tutumdan coxdur!");
            }
        }

        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }

    }
}
