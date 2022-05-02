using System;
using System.Globalization;

namespace entradasDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("você digitou ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //string lista = Console.ReadLine();
            //string[] vet = lista.Split(' ');
            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];

            //Console.WriteLine("Foi armazenado em variantes diferentes os seguites itens");
            //Console.WriteLine(lista);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
