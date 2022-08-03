using System;
using System.Globalization;
namespace Estoque
{
    internal class Produto
    {
        private string _nome;
        public double Preco {get; private set;}
        public int Quantidade {get; private set;}

       
        public Produto(string nome,int quantidade)
        {
            _nome = nome;
            Preco = 500.00;
            Quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length > 1)
                {
                    _nome = value;
                }

            }
        }

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
