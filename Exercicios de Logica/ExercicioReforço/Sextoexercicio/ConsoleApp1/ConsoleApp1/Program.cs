using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool cond1 = a < 10;
            bool cond2 = a < 200;
            bool cond3 = a > 10;
            bool cond4 = a > 5;


            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);
            Console.WriteLine(cond4);
            Console.WriteLine("------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c6);
            Console.WriteLine(c5);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

        }
    }
}
