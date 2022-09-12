using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Esse numero é negativo!");
            }
            else
            {
                Console.WriteLine("Esse número é possitivo!");
            }

        }
    }
}
