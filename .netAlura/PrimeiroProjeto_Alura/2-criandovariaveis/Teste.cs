using System;
using System.Globalization;

namespace _2_criandovariaveis
{
    class Teste
    {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }

        public double Imposto { get; set; }


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double procentagem)
        {
            SalarioBruto += (SalarioBruto / 100) * 10;
        }

        public override string ToString()
        {
            return Nome
                 + " , "
                 + "$ "
                 + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
