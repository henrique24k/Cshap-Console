using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;
            int impar = 0, par = 0, num;

            do
            {
                Console.WriteLine("Digite um numero inteiro: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 1)
                {
                    impar++;
                }
                else
                {
                    par++;
                }
                Console.WriteLine("Dejesa Sair? S ou N: ");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta != 'S');

            Console.WriteLine("Voce digitou {0} impares e {1} pares ", impar, par);

            Console.ReadKey();

        }
        

    }
}
