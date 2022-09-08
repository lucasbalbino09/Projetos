using System;
using System.Globalization;
namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario pessoa1 = new Salario();
            Salario pessoa2 = new Salario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            pessoa1.nome1 = Console.ReadLine();
            Console.WriteLine("Salário: ");
            pessoa1.Valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: ");
            pessoa1.nome2 = Console.ReadLine();
            Console.WriteLine("Salário: ");
            pessoa2.Valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double res = Salario.Media(pessoa1.Valor1, pessoa2.Valor2);

            var Maior = pessoa1.Valor1 > pessoa2.Valor2 ? pessoa1.nome1 : pessoa2.nome2;
            Console.WriteLine($"Salario médio: {res.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("o Maior salario é do Funcionario(a)" + Maior);


        }
    }
}
