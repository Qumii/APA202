using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    internal class Car
    {
        private int _horsePower=300;

        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                //_horsePower = value;
            }
        }



        //public Car()
        //{
        //    Person person = new Person();
        //    Console.WriteLine(person.name);
        //}
    }
}
