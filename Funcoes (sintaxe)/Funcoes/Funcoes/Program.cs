using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros inteiror.");

            string numero = Console.ReadLine();
            string[] vet = numero.Split(' ');
            int numero1 = int.Parse(vet[0]);
            int numero2 = int.Parse(vet[1]);
            int numero3 = int.Parse(vet[2]);

            double resultado = Maior(numero1, numero2, numero3);

            Console.WriteLine("Maior = " + resultado);
        }



        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c )
            {
                m = a;

            } else if(b > c)
            {
                m = b;
            } else
            {
                m = c;
            }
            return m;
        }
    }
}
