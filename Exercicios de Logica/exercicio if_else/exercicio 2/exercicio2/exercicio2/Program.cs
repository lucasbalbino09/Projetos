using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vou ver se seu numero é impar ou par, coloque um numero");
            int numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("este numero é par");
            } 
            else
            {
                Console.WriteLine("este Numero é impar.");
            }
        }
    }
}
