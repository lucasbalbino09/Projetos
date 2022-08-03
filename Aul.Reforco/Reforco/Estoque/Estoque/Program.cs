using System;
using System.Globalization;
namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto discricao = new Produto("Tv",10);

             
            Console.WriteLine(discricao);

            //Console.WriteLine("Entre com os dados do produto:");
            //Console.Write("Nome: ");
            //discricao.Nome = Console.ReadLine();
            //Console.Write("preço: ");
            //discricao.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //discricao.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + discricao);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //discricao.AdicionarProdutos(qte);
            //Console.WriteLine();

            //Console.Write("Dados atualizados: " + discricao);
            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //discricao.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.Write("Dados atualizados: " + discricao);

            //Console.ReadLine();
        }
    }
}
