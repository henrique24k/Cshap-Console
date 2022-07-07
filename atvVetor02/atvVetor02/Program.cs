using System;

namespace atvVetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double salario_min;
            double[] salarios = new double[10];

            Console.WriteLine("Digite o Salario minimo : ");
            salario_min = double.Parse(Console.ReadLine());

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
