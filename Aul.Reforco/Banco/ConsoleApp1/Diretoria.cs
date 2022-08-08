using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Diretoria
    {
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovacao()
        {
            if (NotaFinal() >= 6.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ResultFim()
        {
            if (Aprovacao())
            {
                return ' ';
            }
            else
            {
                return 6.00 - NotaFinal();
            }

        }

    }
}
