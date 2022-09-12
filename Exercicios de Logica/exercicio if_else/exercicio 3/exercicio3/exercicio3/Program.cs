using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor:");
            int PrimeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            int SegundoValor = int.Parse(Console.ReadLine());

            if (PrimeiroValor % SegundoValor == 0 || SegundoValor % PrimeiroValor == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não multiplos");
            }
        }
    }
}
