using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digíte um número que representará a capita, taxa de juros e meses para poder calcular o montante final de um investimento a juros simples.");
            Console.Write("Capital:");
            double CC=Convert.ToDouble(Console.ReadLine());
            Console.Write("Taxa de juros:");
            double I=Convert.ToDouble(Console.ReadLine());
            Console.Write("Meses:");
            double T=Convert.ToDouble(Console.ReadLine());
            double resultado=CC * I;
            double resultado_1=resultado / 100;
            double resultado_2=resultado_1 * T;
            double J=resultado_2;
            double resultado2=CC + J;
            Console.Clear();
            Console.WriteLine($"Juros= {resultado_2:C}");
            Console.WriteLine($"Montante= {resultado2:C}");
        }
    }
}
