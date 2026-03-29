using _06_InterfaceAbstraction.Models;
using System.Threading.Channels;

namespace _06_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine("Birinci ededi daxil edin:");
            calculation.Num1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Emeliyyati daxil edin ('+', '-', '*', '/'):");
            calculation.Operation=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil edin:");
            calculation.Num2= Convert.ToDouble(Console.ReadLine());

            double result=calculation.Calculate();
            Console.WriteLine("Netice: " + result);

            
        }
    }
}
