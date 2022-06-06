using System;

namespace num_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insira um numero inteiro: ");

            int x = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= x; cont++)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine(cont);  
                }
            }
            Console.WriteLine("Fim da Operação.");
            Console.ReadLine();
        }
    }
}
