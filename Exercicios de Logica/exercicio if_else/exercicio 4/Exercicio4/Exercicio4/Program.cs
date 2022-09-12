using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Horas Inicial do Jogo:");
            int HorasInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Fim do Jogo:");
            int HorasFim = int.Parse(Console.ReadLine());
            int duracao;
            if (HorasInicio < HorasFim)
            {
                duracao = HorasFim - HorasInicio;
            }
            else
            {
                duracao = 24 - (HorasInicio - HorasFim) ;
            }

            Console.WriteLine(duracao);
        }
    }
}
