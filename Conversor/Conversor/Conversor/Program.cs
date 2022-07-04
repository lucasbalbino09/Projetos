using System;
using System.Globalization;
namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Res1 = ConversorDolar.ConversorDemoeda(dolar, quant);


            Console.Write("Valor a ser pago em Reais: " + Res1.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
        
    }
}
