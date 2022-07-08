using System;

namespace ExibindoCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for(i = 0; i <= 26; i++)
            {
                char a = Convert.ToChar(i);
                Console.WriteLine(i+""+a);
            }

            Console.ReadKey();
        }
    }
}
