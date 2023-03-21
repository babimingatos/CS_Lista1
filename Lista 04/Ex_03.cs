using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parImpar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor %2== 0){
                Console.Write("Esse número é par.");

            }
            else
            {
                Console.Write("Esse número é ímpar");
            }
            Console.Read();
        }
    }
}
