using Couse;
using System;
using System.Globalization;
namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Salario Segundo = new Salario();
            Salario Primeiro = new Salario();
            Salario Medi = new Salario();

            Console.WriteLine("Dados do Fucionario:");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            Primeiro.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Primeiro.SalarioTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Fucionario:");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            Segundo.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Segundo.SalarioTotal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Medi.resultado = (Primeiro.SalarioTotal + Segundo.SalarioTotal) / 2.00;
                      
            Console.WriteLine($"Valor total é: {Medi.resultado.ToString("C2", CultureInfo.CurrentCulture)}");
            Console.ReadLine();


        }

    }
}
