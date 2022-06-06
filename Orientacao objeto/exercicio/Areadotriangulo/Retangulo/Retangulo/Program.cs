using System;
using System.Globalization;
namespace Retangulo
{
    class Program
    { 
        static void Main(string[] args)
        {
            Calcular Cursor = new Calcular();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            Cursor.Larg = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Cursor.Alt = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine(Cursor);


            Console.ReadLine();
        }
    }
}
