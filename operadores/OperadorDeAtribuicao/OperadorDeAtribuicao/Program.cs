using System;

namespace OperadorDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);


            int a = 5;
            int b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);

        }
    }
}
