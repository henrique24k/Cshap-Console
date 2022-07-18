using System;

namespace MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numero para saber qual é maior :");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /* Com estrutura de repetição:
       
            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }

            Console.ReadKey();
            */

            double resultado = maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }

        static int maior(int a, int b, int c)
        {
            /* Com função */

            int m;
            if(a > b && a > c)
            {
                m = a;
            }
            else if(b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }

    }
}
