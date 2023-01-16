using System;
using System.IO;

class Programa
{
    static void Main(String[] args)
    {
        int fatorial = 1;

        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }

        Console.WriteLine("----------------------------------");


        for (int i = 3; i < 100; i += 3 )
        {
            try
            {
                Console.WriteLine(i);

                return;
            }

            catch (IOException ex)

            {
                Console.WriteLine("Erro na operação !");
            }
            
        }

        Console.ReadKey();
    }
}