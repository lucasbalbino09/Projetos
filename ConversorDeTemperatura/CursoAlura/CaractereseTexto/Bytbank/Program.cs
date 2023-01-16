using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bytbank
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContadoAndre = new ContaCorrente();

            ContadoAndre.titular = "André";
            ContadoAndre.numero_agencia = 15;
            ContadoAndre.conta = "1010-x";

            Console.Write($"Qual o valor de deposito inicial: R$ ");
            ContadoAndre.saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Saldo atual: R$ {ContadoAndre.saldo}");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Qual o Valor para deposito ? R$ ");
            var Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ContadoAndre.Deposito(Deposito) == true)
            {

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Saldo da Conta atualizada: R$ {ContadoAndre.saldo}");

            }
            else
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Valor de deposito ultrapassa R$ 1.000,00");

            }

            Console.WriteLine("--------------------------------------------------");
            Console.Write($"Valor que você ira sacar: R$ ");
            var Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (ContadoAndre.Retirar(Saque) == true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Saldo da Conta atualizada: R$ {ContadoAndre.saldo}");

            }
            else
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Transação não aprovada.");
            }


            Console.ReadKey();

        }
    }
}
