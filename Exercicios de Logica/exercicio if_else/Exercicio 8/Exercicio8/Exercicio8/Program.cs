using System;
using System.Globalization;
namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado;
            if (Salario <= 2000.00)
            {
                resultado = 0.0;

            }
            else if (Salario <= 3000.00)
            {
                resultado = (Salario - 2000.00) * 0.08;

            }
            else if (Salario <= 4500.00)
            {
                resultado = (Salario - 3000.00) * 0.18 + 1000.0 * 0.08;

            }
            else
            {
                resultado = (Salario - 4500.0) * 0.28 + 1500.00 * 0.18 + 1000.0 * 0.8;

            }
            if (resultado == 0.0)
            {
                Console.WriteLine("Insento");
            } else
            {
                Console.WriteLine("R$" + resultado.ToString("F2",CultureInfo.InvariantCulture));
            }
            
            
        }
    }
}
