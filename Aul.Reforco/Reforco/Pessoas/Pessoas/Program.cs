using System;

namespace Pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pess Primeira = new Pess();
            Pess segunda = new Pess();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            Primeira.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Primeira.Idade = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            segunda.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.Idade = int.Parse(Console.ReadLine());


            var res = segunda.Idade > Primeira.Idade ? segunda.Nome : Primeira.Nome;

            Console.WriteLine($"Pessoa mais velha: {res}");



        }
    }
}
