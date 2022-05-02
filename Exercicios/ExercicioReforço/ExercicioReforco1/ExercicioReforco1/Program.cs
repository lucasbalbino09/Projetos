using System;

namespace ExercicioReforco1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro numero");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo numero");
            double n2 = double.Parse(Console.ReadLine());

            double result = n1 + n2;
            Console.WriteLine($"A Soma de {n1} + {n2} = {result}");

        }
    }
}
