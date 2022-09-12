using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu combustivel?");
            int Codigo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (Codigo != 4)
            {
                if (Codigo == 1)
                {
                    alcool = alcool + 1;

                } else if(Codigo == 2)
                {
                    gasolina = gasolina + 1;

                } else if(Codigo == 3)
                {
                    diesel = diesel + 1; 
                }

                Codigo = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
