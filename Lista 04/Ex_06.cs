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

            Console.Write("Digite o primeiro valor: ");
            double um = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double dois = double.Parse(Console.ReadLine());

            double adicao = um + dois;

            if (adicao > 10){
                double raiz = Math.Pow(adicao, 1.0 / 3.0);

                Console.Write($"Soma: {adicao}\n\nRaíz: {raiz}");
            }
            else
            {
                Console.Write($"Soma: {adicao}\n\nDigitados:\nUm: {um}\nDois: {dois}");
            }

            Console.Read();
        }
    }
}
