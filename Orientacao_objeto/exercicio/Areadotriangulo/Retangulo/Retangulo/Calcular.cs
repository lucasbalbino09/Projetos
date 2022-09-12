using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Retangulo
{
    class Calcular
    {
        public double Larg;
        public double Alt;

        public double Area()
        {
            return Larg * Alt ;
        }
        public double Perimetro()
        {
            return Larg * 2 + Alt * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Larg, 2) + Math.Pow(Alt, 2));
        }

        public override string ToString()
        {
            return "Area = "
                 + Area().ToString("F2", CultureInfo.InvariantCulture)
                 + " "+ " Perimetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                 + " " + "  Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
                  

        }
    }
}
