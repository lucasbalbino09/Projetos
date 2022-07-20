using System;
using System.Globalization;
namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int valor)
        {
            Quantidade += valor;
        }

         public void RemoverProdutos(int valor)
        {
            Quantidade -= valor;
        }




        public override string ToString()
        {
            return Nome
                + " , "
                + "R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " Unidades, "
                + "Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
