using System;
using System.Globalization;


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Res = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Res.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Res.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + Res.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + Res.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Res.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
