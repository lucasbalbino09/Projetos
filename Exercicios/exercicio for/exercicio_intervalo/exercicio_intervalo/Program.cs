using System;

namespace exercicio_intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas vezes você vai jogar? ");
            int x = int.Parse(Console.ReadLine());
            int N = 0;

            int cont_in = 0;
            int cont_out = 0;

            for (int Cont = 1; Cont <= x; Cont++ )
            {
                 N = int.Parse(Console.ReadLine());


                if (N >= 10 && N <= 20)
                {
                    cont_in = cont_in + 1;
                } else
                {
                    cont_out = cont_out + 1;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");


            Console.ReadLine();
        }
    }
}
