using System;
using System.Globalization;

namespace RaioStaticv2
{
    class Program
    {
        Calculadora calc = new Calculadora();

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write(" Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vol = calc.Volume(raio); // Declarei meu método statico dentro de uma Variavel.

            Console.WriteLine(" Circunferência: " + calc.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)); //resultado direto da circunferencia. 
            Console.WriteLine(" Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
