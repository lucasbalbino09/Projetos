using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Banco
    {
        public int Cc { get; private set; }
        public string Titular { get; private set; }
        public double Saldo;

        public Banco()
        {

        }

        public Banco(int conta, string titular)
        {
            Cc = conta;
            Titular = titular;

        }



        public void Valor(double dp)
        {
            Saldo = dp;
        }

        public void ValordeEntrada(double quant)
        {
            Saldo = Saldo + quant;
        }

        public void Valordesaque(double quant)
        {
            Saldo = (Saldo - quant) - 5;
        }


        public override string ToString()
        {
            return "Conta: " +
                Cc +
                " , " +
                "Titular: " +
                Titular +
                " , " +
                "Saldo: R$ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
