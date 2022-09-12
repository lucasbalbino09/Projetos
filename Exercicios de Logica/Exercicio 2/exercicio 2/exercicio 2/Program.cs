using System;
using System.Globalization;
namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque seu Nome completo: ");
            string n = Console.ReadLine();
            string [] Nome = n.Split(' ');
            string pnome = Nome[0];
            string snome = Nome[1];
            string tnome = Nome[2];

            Console.WriteLine("Quantos Quartos tem em sua casa ? ");
            int Quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Coloque um valor : ");
            double Valorp = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Muito Bem, agora por favor, ultimo nome , idade e altura:");
            string n2 = Console.ReadLine();
            string[] vet = n2.Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double alt = double.Parse(vet[2]);

            Console.WriteLine("Seus Dados São:");
            Console.WriteLine("Nome Completo : " + n);
            Console.WriteLine("Quartos que tem em sua Casa : " + Quartos);
            Console.WriteLine("Valor do Preço do produto : " + Valorp.ToString("F2"));
            Console.WriteLine("Seus Dados gerais são : " + n2);
            
        }
    }
}
