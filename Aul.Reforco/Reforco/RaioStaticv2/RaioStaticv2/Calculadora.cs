using System;


namespace RaioStaticv2
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double r) // Membro statico que não necessita do objeto para ser invocado no programa principal.
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r) // Membro statico que não necessita do objeto para ser invocado no programa principal.
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}
