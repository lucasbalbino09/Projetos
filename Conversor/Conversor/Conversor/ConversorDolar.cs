using System;
using System.Globalization;

namespace Conversor
{
    class ConversorDolar
    {
        public static double iof = 6.0;

        public static double ConversorDemoeda(double reais, double quantia)
        {
            double total = quantia * reais;

            return total + total * iof / 100.0;

        }
    }
}
