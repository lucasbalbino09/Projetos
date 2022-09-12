using System;
using System.Globalization;
namespace SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, R, pi = 3.14159;

             Console.WriteLine("Colque por favor o Raio do Circulo");
             R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine($"O Valor do Area é de {A.ToString("F4",CultureInfo.InvariantCulture)}");

        }
    }
}
