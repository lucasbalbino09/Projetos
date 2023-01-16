using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoEmConsole
{
    class Temperatura
    {
        public static double Celsius;
        public static double Fahrenheit;


        public static double ConversorCelsius(double TempF)
        {
            return Celsius = (TempF - 32) / 1.8;
        }


        public static double ConversorFahrenheit(double TempC)
        {
            return Fahrenheit = (TempC * 1.8) + 32;
        }

    }
}
