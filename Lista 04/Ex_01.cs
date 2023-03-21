using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace killowatt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de KWh: ");
            double kwh = double.Parse(Console.ReadLine());

            Console.Write("Digite o salário minimo: ");
            double salario = double.Parse(Console.ReadLine());

            double valorKWH = (salario / 7) / 100;
            double conta = valorKWH * kwh;
            double desconto = conta * 0.1;
            double contaDesc = conta - desconto;
            
            Console.Write(
                $"\n\nCada KW vale: {valorKWH}\n\n O valor da conta será: {conta}" +
                $"\n\n Com desconto de 10%: {contaDesc}");

            Console.Read();
        }
    }
}
