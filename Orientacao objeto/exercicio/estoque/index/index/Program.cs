using System;
using System.Globalization;
namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque p = new Estoque(); // Chamando a Classe como inicio. 



            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine(); // p.nome é a vareavel P declarada em cima e a chamada da variavel dentro da classe. 
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
