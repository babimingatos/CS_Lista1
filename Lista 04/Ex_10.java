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
            Console.Write("Digite a altura do degrau: ");
            double degrau = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura que gostaria de chegar: ");
            double altura = double.Parse(Console.ReadLine());


            double alcancar = altura / degrau;

            Console.Write($"Precisará de {alcancar} degraus");

            Console.Read();

        }
    }
}
