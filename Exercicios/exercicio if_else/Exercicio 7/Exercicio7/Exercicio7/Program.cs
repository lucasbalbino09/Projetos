using System;
using System.Globalization;
namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("coloque o Valor de X:");
            double x = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("coloque o Valor de Y:");
            double y = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            
            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");

            } else if (x == 0.0)
            {
                Console.WriteLine("eixo Y");

            }else if (y == 0.0)
            {
                Console.WriteLine("eixo X");

            } else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");

            } else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");

            } else if (x < 0.0 && y < 0.00) {

                Console.WriteLine("Q3");

            } else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
