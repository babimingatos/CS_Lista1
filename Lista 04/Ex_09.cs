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
            Console.Write("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            double acrescimo = (salario * 0.25) + salario;

            Console.Write("Salário atual: " + salario + "\nSalário com 25%: " + acrescimo);

            Console.Read();

        }
    }
}
