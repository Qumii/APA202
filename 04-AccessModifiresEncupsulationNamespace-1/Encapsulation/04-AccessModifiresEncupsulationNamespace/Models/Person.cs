using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Person
    {

        //public string name;
        //protected string name;
        //protected internal string name;
        //internal string name;
        //private protected string name;
        private string name;


        //public Person(string name)
        //{
        //    this name=name;
        //}

        public void GetInfo()
        {
            Console.WriteLine($"{this.name}");
        }
    }
}
