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

            Console.Write("Digite o n1: ");
            double um = double.Parse(Console.ReadLine());

            Console.Write("Digite o n2: ");
            double dois = double.Parse(Console.ReadLine());

            Console.Write("Digite o n3: ");
            double tres = double.Parse(Console.ReadLine());


            if (um > 0 & dois > 0 & tres > 0) {

            } else if (um < 0 & dois < 0 & tres < 0) {

            }

            if (um < tres) {
                Console.Write("Três é maior que um");
            } else if (um > tres) {
                Console.Write("Três é maior que um");
            } else if (dois > tres) {
                Console.Write("Dois é maior que tres");
            } else if (dois < tres) {
                Console.Write("Tres é maior que dois");
            } else if (dois > um) {
                Console.Write("Dois é maior que um");
            } else if (dois > um) {
                Console.Write("Dois é maior que um");
            }

            if (um > dois)
            {

            } else if (dois > tres)
            {

            }
               else { }
            Console.Read();

        }
    }
}
