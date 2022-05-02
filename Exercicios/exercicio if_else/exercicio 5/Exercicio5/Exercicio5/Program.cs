using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seus dados a Baixo:");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Codigo, Quantidade:");
            string tabela = Console.ReadLine();
            string[] vet = tabela.Split(' ');
            int cod = int.Parse(vet[0]);
            int quant = int.Parse(vet[1]);
            double total = 0.0;
           

            if (cod  == 1 )
            {
                total = quant * 4.00;
            } else if(cod == 2)
            {
                total = quant * 4.50;
            } else if (cod == 3)
            {
                total = quant * 5.00;
            } else if (cod == 4)
            {
                total = quant * 2.00;
            } else if (cod == 5)
            {
                total = quant * 1.50;
            }

            Console.WriteLine($"o valor total a ser pago é de R$ {total.ToString("F2",CultureInfo.InvariantCulture)} Reais");
        }

    }
}
