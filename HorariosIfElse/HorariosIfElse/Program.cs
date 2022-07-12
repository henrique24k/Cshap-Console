using System;

namespace HorariosIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;

            Console.WriteLine("Digite a hora: ");
            hora = int.Parse(Console.ReadLine());

            if (hora <= 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora > 19)
            {
                Console.WriteLine("Boa noite!");
            }

            else 
            {
                Console.WriteLine("Boa tarde!");
            }

            Console.ReadKey();

        }
    }
}
