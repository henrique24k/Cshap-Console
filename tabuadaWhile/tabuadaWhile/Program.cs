using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuadaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, mult, resultado;

            Console.WriteLine("Digite um numero para mostrar na tabuada: ");
            num = int.Parse(Console.ReadLine());

            mult = 1;

            while (mult <=100)
            {
                resultado = num * mult;
                Console.WriteLine("{0} * {1} = {2}", num, mult, resultado);
                mult++;
            }

            Console.ReadKey();

        }
    }
}
