
using System.Globalization;

namespace index
{
    class Estoque
    {
        // Variaveis Publicas, para o escopo principal. 
        
        public string Nome;
        public double Preco;
        public int Quantidade;

        //logica para o sistema. 
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
