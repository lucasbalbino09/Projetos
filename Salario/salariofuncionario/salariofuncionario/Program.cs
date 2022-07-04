using System;
using System.Globalization;

namespace salariofuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularSalario res = new CalcularSalario();


            Console.Write("Nome do funcionario: ");
            res.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            res.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            res.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionario: {res}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite a porcentagem para o aumento de salario:");
            double aument = double.Parse(Console.ReadLine());
            res.AumentarSalario(aument);

            Console.WriteLine($"Dados Atualizados: {res}");

        }
    }
}
