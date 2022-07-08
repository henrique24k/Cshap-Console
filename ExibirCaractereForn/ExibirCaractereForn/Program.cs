using System;

namespace ExibirCaractereForn
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            char a;

            Console.WriteLine("Digite um caracter: ");
            a = char.Parse(Console.ReadLine());

            b = Convert.ToInt16(a);

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
