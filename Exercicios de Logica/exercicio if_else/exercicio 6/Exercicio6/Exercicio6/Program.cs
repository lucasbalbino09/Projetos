using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um Numero:");
            double valor = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
           

            if (valor >= 0.0 && valor <= 25.00 )
            {
                Console.WriteLine("intervalo de (0,25)");

            } else if (valor >= 25.00 && valor <= 50.00)
            {
                Console.WriteLine("intervalo de (25,50)");

            } else if (valor >= 50.00 && valor <= 75.00)
            {
                Console.WriteLine("intervalo de (50,75)");

            }else if (valor >= 75.00 && valor <= 100.00)
            {
                Console.WriteLine("intervalo de (75,100)");

            }else
            {
                Console.WriteLine("Fora de Intervalor.");

            }
           
            
        }
    }
}
