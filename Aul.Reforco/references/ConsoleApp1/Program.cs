using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p); 

            p = new Point(); // não é necessario mas é possivel. 
            Console.WriteLine(p);
        }
    }
}
