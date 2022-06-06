using System.Globalization;

namespace Couse
{
    class Salario
    {
        public string Nome;
        public double Quantia1;
        public double Quantia2;
        public double v = 2.00; 


        public double Media()
        {
            return (Quantia1 + Quantia2) / v;
        }

        public override string ToString()
        {
            return Media().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
