﻿using System;
using System.Globalization;

namespace WhileUdy
{
    class Program
    {
        static void Main(string[] args)
        {
        double x;

        Console.Write("Digite um número: ");
        x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while(x >= 0.0) { 
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Número negativo!");
        Console.ReadKey();

        }
    }
}
