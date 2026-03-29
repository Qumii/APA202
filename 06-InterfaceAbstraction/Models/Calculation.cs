using _06_InterfaceAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Models
{
    internal class Calculation : ICalculation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; } 
        public char Operation { get; set; }

        public double Calculate()
        {
            switch (Operation)
            {
                case '+':
                    return Num1 + Num2;
                case '-':
                    return Num1 - Num2;
                case '*':
                    return Num1 * Num2;
                case '/':
                    if (Num2==0)
                    {
                        Console.WriteLine("0-a bolmek olmaz");
                        return 0;
                    }
                    return Num1 / Num2;
                    default:
                    Console.WriteLine("Yanlis emeliyyat");
                    return 0;
            }
        }
    }
}
