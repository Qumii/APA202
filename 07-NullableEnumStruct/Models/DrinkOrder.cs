using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullableEnumStruct.Models
{
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Price { get; set; }

        public DrinkType Drink { get; set; }

        public DrinkSize Size { get; set; }

        public OrderStatus Status { get; set; }


        public DrinkOrder(int orderNumber, string customerName, DrinkType drink,DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();


        }

      

        public decimal CalculatePrice()
        {
            decimal price = 0;

            switch (Drink)
            {
                case DrinkType.Coffee:
                    if (Size == DrinkSize.Small)
                    {
                        price = 3;
                    }else if (Size == DrinkSize.Medium)
                    {
                        price = 4;
                    }
                    else
                    {
                        price = 5;
                    }
                    break;

                case DrinkType.Tea:
                    if (Size == DrinkSize.Small)
                    {
                        price = 2;
                    }else if (Size == DrinkSize.Medium)
                    {
                        price = 3;
                    }
                    else
                    {
                        price = 4;
                    }
                    break;

                case DrinkType.Juise:
                    if (Size == DrinkSize.Small)
                    {
                        price = 4;
                    }else if (Size == DrinkSize.Medium)
                    {
                        price = 5;
                    }
                    else
                    {
                        price = 6;
                    }
                    break;

                case DrinkType.Water:
                    if (Size == DrinkSize.Small)
                    {
                        price = 1;
                    }else if (Size == DrinkSize.Medium)
                    {
                        price = 1.5m;
                    }
                    else
                    {
                        price = 2;
                    }
                    break;

            }return price;
           

        }

        public void UpdateStatus(OrderStatus newStatus) 
        { 
            Status=newStatus;
            Console.WriteLine($"Sifaris {OrderNumber} statusu: {newStatus}");
            Console.WriteLine(" ");
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Sifaris nomresi: {OrderNumber}");
            Console.WriteLine($"Musteri adi: {CustomerName}");
            Console.WriteLine($"Icki novu: {Drink}");
            Console.WriteLine($"Olcu: {Size}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Qiymet: {Price}");
            Console.WriteLine($" ");
        }
    }
}
