using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Senha: ");
            int senha = int.Parse(Console.ReadLine());


            while (senha != 2002)
            {
                Console.Write("Senha invalida, tente novamente: ");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido!");



            Console.ReadLine();

        }
    }
}
