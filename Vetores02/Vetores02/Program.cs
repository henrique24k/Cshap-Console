using System;

namespace Vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double salario_min = 678.00;
            double[] salarios = new double[10];

            //Atrbuição do calculo no vetor salarios
            for (i = 0; i < salarios.Length; i++)
                salarios[i] = (i + 1) * salario_min;

            //Exibição dos dados calculados
            for (i = 0; i < salarios.Length; i++)
                Console.WriteLine("{0} Salario(s) Minimo(s) = {1}", (i + 1), salarios[i].ToString("#00.00"));

           

            Console.ReadKey();

        }

    }
}
