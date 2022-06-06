using System;

namespace repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int cont = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int cond = 1; cond <= cont; cond++)
            {
                Console.Write("Valor #{0}: ", cond);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
            Console.ReadLine();
        }
        
    }
}
