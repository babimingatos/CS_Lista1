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

            Console.Write("Digite o terceiro valor: ");
            double tres = double.Parse(Console.ReadLine());

           double quatroUm = Math.Pow(um,4);
            double quatroDois =Math.Pow(dois, 4);
            double quatroTres = Math.Pow(tres, 4);

            double soma = quatroDois + quatroTres + quatroUm;

            if(soma % 2 == 0) {
                Console.Write("Essa soma é par");
            }
            else{
                Console.Write("Essa soma é ímpar "); 
                   
            }

            Console.Read();
        }
    }
}
