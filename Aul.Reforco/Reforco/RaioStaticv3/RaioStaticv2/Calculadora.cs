using System;


namespace RaioStaticv3
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r) // Membro statico que não necessita do objeto para ser invocado no programa principal.
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) // Membro statico que não necessita do objeto para ser invocado no programa principal.
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}
