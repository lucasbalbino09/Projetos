using System;

namespace QuartoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, r;

            Console.WriteLine("Insira o primeiro Valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Valor:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Terceiro Valor:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Quarto Valor:");

            d = int.Parse(Console.ReadLine());

            r = (a * b) - (c * d);

            Console.WriteLine($"A Diferencia é de {r}");
        }
    }
}
