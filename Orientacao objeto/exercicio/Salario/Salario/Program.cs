using Couse;
using System;
using System.Globalization;
namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario Primeiro, Segundo, P;

            P = new Salario();
            Segundo = new Salario();
            Primeiro = new Salario();


            Console.WriteLine("Dados do Fucionario:");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            Primeiro.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Primeiro.Quantia1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Fucionario:");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            Segundo.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Segundo.Quantia2 = double.Parse(Console.ReadLine());


           
            Console.WriteLine("Valor total é: " + P);
            Console.ReadLine();
        }

    }
}
