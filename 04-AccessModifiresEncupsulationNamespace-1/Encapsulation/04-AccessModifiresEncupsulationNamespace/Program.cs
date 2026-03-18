using _04_AccessModifiresEncupsulationNamespace.Models;
using System.Reflection;

namespace _04_AccessModifiresEncupsulationNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.name = "Test";
            //Console.WriteLine(student.name);

            //Person person = new Person();   



            //typeof(Person).GetField("name",BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "apa202");

            //var newName = typeof(Person).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(newName);



            Car car = new Car();
            //car.HorsePower = 70;
            Console.WriteLine(car.HorsePower);



        }
    }
}
