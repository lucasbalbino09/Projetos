using System;
using System.Globalization;


namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de computador";

            byte Idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2} reais.");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2} Reais");

            Console.WriteLine($"Registro: {Idade} Anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {preco3:F8}");
            Console.WriteLine("Arredondando (três casas decimais): {0:F3}", preco3);
            Console.WriteLine("Separando decimal invariant culture: " + preco3.ToString("F3",CultureInfo.InvariantCulture));
        }
    }

}
