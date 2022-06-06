using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float R = float.Parse(Console.ReadLine());
            double N = 3.14159;
            double A = N * Math.Pow(R, 2);

            Console.WriteLine($"A={A.ToString("F4")}");
        }
    }
}
