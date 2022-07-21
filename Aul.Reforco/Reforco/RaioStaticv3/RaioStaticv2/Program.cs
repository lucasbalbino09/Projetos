using System;
using System.Globalization;

namespace RaioStaticv3
{
    class Program
    {       

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write(" Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vol = Calculadora.Volume(raio); // Declarei meu método statico dentro de uma Variavel.

            Console.WriteLine(" Circunferência: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)); //resultado direto da circunferencia. 
            Console.WriteLine(" Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
