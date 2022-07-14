using System;
using System.Globalization;
namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto discricao = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            discricao.Nome = Console.ReadLine();
            Console.Write("preço: ");
            discricao.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            discricao.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + discricao);





        }
    }
}
