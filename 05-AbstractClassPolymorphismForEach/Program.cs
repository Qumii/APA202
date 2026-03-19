using _05_AbstractClassPolymorphismForEach.Models;

namespace _05_AbstractClassPolymorphismForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "E200", 2023, "AA", 220, 4, 500, true);
            Car car2 = new Car("BMW", "320i", 2022, "BB", 235, 4, 480, true);
            Car car3 = new Car("Toyota", "Camry", 2021, "CC", 210, 4, 524, true);

            Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "MM", 299, 998, false, "Sport");
            Motorcycle moto2 = new Motorcycle("Toyota", "Camry", 2022, "MM", 180, 1868, true, "Cruiser");

            Truck truck1 = new Truck("MAN", "TGX", 2020, "TT", 120, 18, 3, 12);
            Truck truck2 = new Truck("Volvo", "FH16", 2021, "TT", 110, 25, 4, 18);

            Vehicle[] vehicles = { car1, car2, car3, moto1, moto2, truck1, truck2 };

            foreach (Car cars in new[] { car1, car2, car3 })
            {
                cars.ShowCarInfo();
                Console.WriteLine("Yanacaq deyeri 500km: " + cars.CalculateFuelCost(500));
                Console.WriteLine();

            }

            foreach (Motorcycle motor in new[] { moto1, moto2 })
            {
                motor.ShowMotorcycleInfo();
                Console.WriteLine("Yanacaq deyeri 300km: " + motor.CalculateFuelCost(300));
                Console.WriteLine();
            }

            foreach (Truck trucks in new[] { truck1, truck2 })
            {
                trucks.ShowTruckInfo();
                Console.WriteLine("Yanacaq deyeri 800km: " + trucks.CalculateFuelCost(800));
                Console.WriteLine();
            }



            Console.WriteLine("Truck1-e elave yuk:");

            truck1.LoadCargo(5);

            Console.WriteLine("Yeni yanacaq xerci:" + truck1.CalculateFuelCost(800));


            int total = vehicles.Length;
            Console.WriteLine($"Umumi neqliyyat sayi: {total}");


            double sum = 0;
            foreach (var item in vehicles)
            {
                sum += item.MaxSpeed;
            }
            double average = sum / vehicles.Length;
            Console.WriteLine("Orta maksimum suret:" + average);

            double maxCost = 0;
            Vehicle expensiveVehicle = null;

            foreach (var item in vehicles)
            {
                double cost = 0;

                if (item is Car)
                {
                    cost = item.CalculateFuelCost(500);
                }
                else if (item is Motorcycle)
                {
                    cost = item.CalculateFuelCost(300);
                }

                else if (item is Truck)
                {
                    cost = item.CalculateFuelCost(800);
                }

                if (cost > maxCost)
                {
                    maxCost = cost;
                    expensiveVehicle = item;
                }


            }
            Console.WriteLine("En bahali yanacaq xerci: " + maxCost);
            Console.WriteLine("En bahali yanacaq xerci olan neqliyyat:");
            expensiveVehicle.ShowBasicInfo();

        }
    }
}
