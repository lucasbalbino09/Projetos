using System;

namespace pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Primeirap, Segundap;

            Primeirap = new Pessoa();
            Segundap = new Pessoa();

            Console.WriteLine("Dados da 1° Pessoa:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nome da primeira Pessoa:");
            Primeirap.Nome = Console.ReadLine();
            Console.WriteLine("Idade da Pessoa:");
            Primeirap.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");

            Console.WriteLine("Dados da primeira 2° pessoa:");
            Console.WriteLine("Nome da primeira Pessoa:");
            Segundap.Nome = Console.ReadLine();
            Console.WriteLine("Idade da segunda pessoa:");
            Segundap.Idade = int.Parse(Console.ReadLine());

            if (Primeirap.Idade > Segundap.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é a {Primeirap.Nome}");
            }else
            {
                Console.WriteLine($"A pessoa mais velha é a {Segundap.Nome}");
            }

            Console.ReadLine();

        }
    }
}
