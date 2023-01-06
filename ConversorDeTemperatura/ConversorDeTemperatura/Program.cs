using System;
using System.Globalization;

namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor!");


            Console.WriteLine("Valor em Celsius!");
            double Cels = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor em Fahrenheit!");
            double Fahr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var ValorC = Temperatura.ConversorCelsius(Cels);

            Console.WriteLine($"Valor em Celsius: {ValorC.ToString("F2", CultureInfo.InvariantCulture)} ");

            var ValorF = Temperatura.ConversorFahrenheit(Fahr);

            Console.WriteLine($"Valor em Fahrenheit {ValorF.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();

        }
    }
}
