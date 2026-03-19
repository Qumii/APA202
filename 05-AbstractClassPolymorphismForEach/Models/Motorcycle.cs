using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public string Type { get; set; }

        public Motorcycle(string brand, string model, int year, string plateNumber, int maxSpeed, int engineCapacity, bool hasSidecar, string type) : base(brand, model, year, plateNumber, maxSpeed)
        {
            EngineCapacity = engineCapacity;
            HasSidecar = hasSidecar;
            Type = type;
        }

        public void ShowMotorcycleInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Muherrik hecmi:{EngineCapacity}cc, Elave oturacaq:{HasSidecar}, Nov:{Type}");

        }

        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }
    }
}
