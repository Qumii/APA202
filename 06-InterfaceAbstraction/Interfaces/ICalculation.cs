using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Interfaces
{
    internal interface ICalculation
    {
         double Num1 { get; set; }
         double Num2 { get; set; }
         char Operation { get; set; }

        double Calculate();
    }
}
