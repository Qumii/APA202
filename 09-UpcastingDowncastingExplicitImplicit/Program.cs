using _09_UpcastingDowncastingExplicitImplicit.Models;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Upcasting-Downcasting
            //Dog dog = new Dog { AvgLifeTime=20, Breed="Pudel",Gender="female", Name="Paris" };
            //Eagle eagle = new Eagle { AvgLifeTime = 30, FlySpeed=250, Gender="male" };

            //////upcasting-implicit
            ////Animal animal = dog;
            ////Animal animal1 = eagle;

            //////downcasting-explicit
            ////Dog dog1 = (Dog)animal;
            ////Eagle eagle1 = (Eagle)animal;


            //Animal[] animals = { eagle, dog };

            //foreach (var animal in animals)
            //{
            //    //Eagle eagle1 = (Eagle)animal;

            //    //Eagle eagle1 = animal as Eagle;



            //    //if (eagle1 != null)
            //    //{
            //    //    eagle1.Fly();
            //    //}

            //    if (animal is Eagle)
            //    {
            //        Eagle eagle1 = (Eagle) animal;
            //    }
            //    else
            //    {
            //        Dog dog1 = (Dog) animal;    
            //    }
            //} 
            #endregion


            #region Boxing-Unboxing
            ////boxing
            //int a = 4;
            //Object b = a as Object;
            //int c = (int)b; 




            //Test test = new Test();
            //ITest test1 = test;
            //Test test2 = (Test)test1;

            #endregion

            Dollar dollar = new(600);
            Manat manat = new(510);

            Dollar dollar1 = manat;
            Console.WriteLine($"{dollar1.USD} USD");

            Manat manat1 = dollar;
            Console.WriteLine($"{manat1.AZN} AZN");


        }
    }

    //public struct Test : ITest
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}

    //public interface ITest
    //{
    //    int Y { get; set; }
    //}
}
