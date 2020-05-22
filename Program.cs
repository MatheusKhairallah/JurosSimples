using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o montante final de um investimento a juros simples.");
            double CC=1200;
            double I=2;
            double T=15;
            double resultado=CC * I;
            double resultado_1=resultado / 100;
            double resultado_2=resultado_1 * T;
            double J=resultado_2;
            double resultado2=CC + J;
            Console.WriteLine($"{resultado_2:C}");
            Console.WriteLine($"{resultado2:C}");
        }
    }
}
