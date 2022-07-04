using System;
using System.Globalization;
namespace index
{
    class Program
    {
        static void Main(string[] args)
        {

            Estoque p = new Estoque("Tv",500.00, 10);


            p.SetNome(""); 

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
               

        }
    }
}
