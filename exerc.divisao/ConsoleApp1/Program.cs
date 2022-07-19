using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos valores? ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <= n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double A = double.Parse(v[0]);
                double B = double.Parse(v[1]);
                double divisao = 0;

                if (B == 0)
                {
                    Console.WriteLine("Divisão imposivel");
                } else
                {
                    divisao = A / B;
                }

                Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));

            }
        }
    }
}
