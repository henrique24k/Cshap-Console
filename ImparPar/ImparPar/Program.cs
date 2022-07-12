using System;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entre com um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else 
            {
                Console.WriteLine("Impar");
            }


        }
    }
}
