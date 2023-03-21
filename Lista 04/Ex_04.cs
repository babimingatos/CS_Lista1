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

            Console.Write("Digite um valor: ");
             double valor = double.Parse(Console.ReadLine());
             double quarta = Math.Pow(valor, 4);
             double quad = Math.Pow(valor, 4);
             double cubo = Math.Pow(valor, 3);
             double seti = Math.Pow(valor,7); 

             double raizQ= Math.Sqrt(valor);
            double raizCub= Math.Pow(valor, 1.0 / 3.0);
            double raizSet = Math.Pow(valor, 1.0 / 7.0);

            if (quarta % 5 == 0 & quarta % 2 == 0) {
                Console.Write($"O número digitado foi: {valor}" +
                              $"\n\nElevado ao cubo: {cubo} " +
                              $"\n\nelevado ao quadrado: {quad}" +
                              $"\n\nElevado a sétima: {seti}");

            }else{
                Console.Write($"O número digitado foi: {valor}" +
                             $"\n\n Elevado ao cubo: {raizCub}, " +
                             $"\n\nelevado ao quadrado: {raizQ}" +
                             $"\n\nElevado a sétima: {raizSet}");

            }
            


            Console.Read();
        }
    }
}
