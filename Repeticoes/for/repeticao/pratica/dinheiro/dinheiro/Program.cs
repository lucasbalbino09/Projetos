using System;
using System.Globalization;
namespace dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total de itens: ");
            int quant = int.Parse(Console.ReadLine());

            double soma = 0;

            for (int cont = 1; cont <= quant; cont ++)
            {
                Console.Write($"Compra {cont} = ");
                double result = double.Parse(Console.ReadLine());
                soma += result;
            }
            Console.WriteLine($"O seu gasto total é de: R$ {soma.ToString("F2")}");

            Console.ReadLine();
        }


    }
}


    
