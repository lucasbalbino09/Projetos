﻿using System;
using System.Globalization;

namespace BancoeConta
{
    internal class Banco
    {
        public int Cc { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        public Banco(int conta, string titular)
        {
            Cc = conta;
            _titular = titular;

        }
        public Banco(int conta, string titular, double DpInicial) : this(conta, titular)
        {
            ValordeEntrada(DpInicial);
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (Titular.Length > 1)
                {
                    Titular = _titular;
                }
                else
                {
                    Titular = null;
                }

            }

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