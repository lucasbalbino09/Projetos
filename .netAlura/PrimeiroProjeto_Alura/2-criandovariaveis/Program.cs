using System;
using System.Globalization;
namespace _2_criandovariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste A = new Teste();

            Console.Write("Nome do Funcionario: ");
            A.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            A.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Impostos: ");
            A.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionario: {A}");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("digite a porcentagem para aumento de salario: ");
            double aument = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A.AumentarSalario(aument);

            Console.Write($"Dados Atualizados: {A}");

            Console.ReadLine();


        }
    }
}
