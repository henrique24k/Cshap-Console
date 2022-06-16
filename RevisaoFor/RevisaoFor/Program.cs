using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for(i=1; i<=150; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i + " Multiplos de 10");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
