﻿using System;
using System.Globalization;


namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Res = new Funcionario();

            Console.Write("Nome: ");
            Res.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            Res.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            Res.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados Atualizados: " + Res);
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Aument = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Res.AumentarSalario(Aument);

            Console.WriteLine("Dados Atualizados: " + Res);

            Console.ReadLine();
        }
    }
}
