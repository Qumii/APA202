using _04_AccessModifiresEncupsulationNamespace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Work : Person
    {
        public Work()
        {
            Person person = new Person();
            //Console.WriteLine(person.name);
            //Console.WriteLine(this.name);
        }
    }
}
