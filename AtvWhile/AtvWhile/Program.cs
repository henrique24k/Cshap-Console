using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, quant = 0;

            string resp = "S";

            while (resp == "S" || resp == "s")
            {
                Console.WriteLine("Digite um valor: ");
                n = int.Parse(Console.ReadLine());
                quant++;

                Console.WriteLine("Deseja digitar outro valor ? S/N");
                resp = Console.ReadLine();

            }

            Console.WriteLine("Voce digitou {0} valores ", quant);

            Console.ReadKey();
        }
    }
}
