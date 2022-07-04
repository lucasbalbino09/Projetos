using System;
using System.Globalization;

namespace salariofuncionario
{
    class CalcularSalario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        

        public double SalarioLiquido()
        {
            return  SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
             SalarioBruto += (SalarioBruto / 100) * 10 ;
        }

        public override string ToString()
        {
            return 
                Nome
                + ", "
                + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
