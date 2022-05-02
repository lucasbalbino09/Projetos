using System;
using System.Globalization;

namespace TerceiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, a, pi = 3.14159;

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            a = pi * R * R;

            Console.WriteLine("A = " + a.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
