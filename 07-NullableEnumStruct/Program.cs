using _07_NullableEnumStruct.Models;
using _07_NullableEnumStruct.Enums;
using System.Data;

namespace _07_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder order1 = new DrinkOrder(101,"Ali", DrinkType.Coffee, DrinkSize.Medium);
            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);


            DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);


            DrinkOrder order3 = new DrinkOrder(103, "Vuqar", DrinkType.Juise, DrinkSize.Small);
            order3.DisplayOrder();

            
            Console.WriteLine("DrinkType:");
            foreach (DrinkType d in Enum.GetValues(typeof(DrinkType)))
            {
                Console.WriteLine(d);
            }

            //Console.WriteLine(" "); --- run edende seliqeli gorunmesi ucun istifade etdim)

            Console.WriteLine(" ");
            Console.WriteLine("DrinkSize:");
            foreach (DrinkSize s in Enum.GetValues(typeof(DrinkSize)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(" ");
            Console.WriteLine("OrderStatus:");
            foreach (OrderStatus o in Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(" ");
            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(DrinkSize.Large.ToString());


            DrinkType drink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            DrinkSize size = (DrinkSize)Enum.Parse(typeof(DrinkSize),"Medium");
            Console.WriteLine(" ");

            Console.WriteLine(drink);
            Console.WriteLine(" ");
            Console.WriteLine(size);
            Console.WriteLine(" ");

            Console.WriteLine("Umumi sifaris: 3");
            Console.WriteLine(" ");
            Console.WriteLine($"Birinci sifarisin qiymeti {order1.Price}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ikinci sifarisin qiymeti {order2.Price}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ucuncu sifarisin qiymeti {order3.Price}");
            Console.WriteLine(" ");

            decimal total = order1.Price + order2.Price + order3.Price;
            Console.WriteLine($"Umumi mebleg: {total}");
        }
        
    }
}
