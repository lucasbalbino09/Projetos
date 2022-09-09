using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.00;


            Console.WriteLine(x.GetValueOrDefault());

        }
    }
}
