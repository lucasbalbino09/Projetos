using System;
using System.Globalization;
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Triangulo x = new Triangulo();
           Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double Resultx = x.Area();
            double Resulty = y.Area();
                      

            Console.WriteLine("Área de x = " + Resultx.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + Resulty.ToString("F4", CultureInfo.InvariantCulture));

           
        }
    }
}

