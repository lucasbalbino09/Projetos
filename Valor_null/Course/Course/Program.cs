using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Serve para dados opcionais!
            double? x = null;
            double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)

            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("Aplicação nula.");



            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("aplicação nula.");


            double a = x ?? 0.0; // é uma questão, x = null ? se for atribua o valor 5.0;
            double b = y ?? 5.0;


            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();


            // operações do nullable(GetValueorDefault, HasValue, Value).

            // operado de coalescência nula é como se fosse o operador ternario. 


        }
    }
}
