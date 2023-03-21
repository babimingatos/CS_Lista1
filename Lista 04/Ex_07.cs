using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * (9.0 / 5.0) + 32.0;

            Console.Write($"A temperatura em fahrenheit é {fahrenheit}");
            Console.Read();
               

        }
    }
}
