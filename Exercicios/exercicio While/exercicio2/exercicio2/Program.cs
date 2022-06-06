using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira suas cordenadas:");
            string coordenada = Console.ReadLine();

            string[] vetor = coordenada.Split(' ');
            int primeira_ordem = int.Parse(vetor[0]);
            int segunda_ordem = int.Parse(vetor[1]);
           

            while (primeira_ordem != 0 && segunda_ordem != 0)
            {
                if (primeira_ordem > 0 && segunda_ordem > 0)
                {
                    Console.WriteLine("Primeiro");
                } else if(primeira_ordem < 0 && segunda_ordem > 0)
                {
                    Console.WriteLine("Segundo");
                } else if (primeira_ordem < 0 && segunda_ordem < 0)
                {
                    Console.WriteLine("Terceiro");
                } else
                {
                    Console.WriteLine("Quarto");
                }
               vetor = Console.ReadLine().Split(' ');
                primeira_ordem = int.Parse(vetor[0]);
                segunda_ordem = int.Parse(vetor[1]);
            }

        }
    }
}
