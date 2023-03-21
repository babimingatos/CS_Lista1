using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenusaComIF
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a base do triângulo: ");
            double baset = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = (baset * altura)/2;

            if (area>0){
                Console.Write("positivo");
            }
            else {
                Console.Write("negativo");
            }

            Console.Read();
        }
    }
}
