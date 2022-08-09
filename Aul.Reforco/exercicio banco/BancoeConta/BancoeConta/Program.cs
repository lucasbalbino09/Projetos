using System;
using System.Globalization;

namespace BancoeConta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o número da conta: ");
            int Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Banco resp = new Banco(Conta, titular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string condicao = Console.ReadLine();

            if (condicao == "s" || condicao == "S")
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double dp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                resp.Valor(dp);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(resp);
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Entre com o valor para depósito: ");
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resp.ValordeEntrada(entrada);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(resp);
            Console.WriteLine("------------------------------------------------------");


            Console.Write("Entre com o valor para saque: ");
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resp.Valordesaque(entrada);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(resp);
            Console.WriteLine("------------------------------------------------------");

            Console.ReadKey();


        }
    }
}
