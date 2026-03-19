using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Car : Vehicle
    {

        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }


        public Car(string brand, string model, int year, string plateNumber, int maxSpeed, int doorsCount, int trunkCapasity, bool isAutomatic) : base(brand, model, year, plateNumber, maxSpeed)
        {
            DoorsCount = doorsCount;
            TrunkCapacity = trunkCapasity;
            IsAutomatic = isAutomatic;
        }


        public void ShowCarInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Qapi sayi:{DoorsCount}, Baqaj tutumu:{TrunkCapacity}L, Avtomat suret qutusu:{IsAutomatic}");
        }

        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }
    }
}
