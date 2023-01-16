using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytbank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;


        public bool Deposito(double Deposi)
        {
            if (Deposi < 1000)
            {
                saldo += Deposi;
                return true;
            }
            else
            {

                return false;
            }


        }

        public bool Retirar(double saque)
        {
            if (saque <= saldo)
            {
                saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
