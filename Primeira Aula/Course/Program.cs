using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos de variaveis.. 
            //bool completo = false;
            //char genero = 'f';
            //char letra = '\u0041';
            //byte numero1 = 126;
            //int numero2 = 1000;
            //int numero3 = 2147483647;
            //long numero4 = 2147483648L;
            //float numero5 = 4.5f;
            //double numero6 = 4.5;
            //string nome = "Maria Green";
            //object obj1 = "Alex Brown";
            //object obj2 = 4.5f; 

            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(numero1);
            //Console.WriteLine(numero2);
            //Console.WriteLine(numero3);
            //Console.WriteLine(numero4);
            //Console.WriteLine(numero5);
            //Console.WriteLine(numero6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            // Valor Minimo e maximo.
            //int n1 = int.MinValue;
            //int n2 = int.MaxValue;
            //sbyte n3 = sbyte.MinValue;
            //decimal n4 = decimal.MaxValue;

            //Console.WriteLine(n4);
            //Console.WriteLine(n2);
            //Console.WriteLine(n1);
            //Console.WriteLine(n3);

            
            int idade = 35;
            double saldo = 120.35785;
            string nome = "Joao";

            Console.WriteLine("{0} tem {1} Anos, e sua conta bancaria é de R${2:F2} reais.", nome , idade , saldo);
            Console.WriteLine("--------------");
            Console.WriteLine($"{nome} tem {idade} Anos, e sua conta bancaria é de R$ {saldo:f2} Reais");
            Console.WriteLine("------");
            Console.WriteLine( nome + " tem " + idade + " Anos e tem sua conta bancaria de R$ " + saldo.ToString("F2" , CultureInfo.InvariantCulture) + " Reais");

             
        }
    }
}
