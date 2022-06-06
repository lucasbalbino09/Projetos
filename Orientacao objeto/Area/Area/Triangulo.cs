﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double Calculararea()
        {
            double P = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return raiz;
        }
    }
}
