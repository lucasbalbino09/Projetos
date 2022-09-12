using System;
using System.Globalization;
namespace SextoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor, Insira os seguintes itens: cod peça, numero de peças, e valor unitario: ");

            string Valores = Console.ReadLine();
            string[] vet = Valores.Split(' ');
            int CodPeça1 = int.Parse(vet[0]);
            int Unidade1 = int.Parse(vet[1]);
            double ValorUnid1 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine("Agora, Insira os mesmos itens da peça 2 : cod peça, numero de peças, e valor unitario: ");

            string Valores2 = Console.ReadLine();
            string[] vetor = Valores2.Split(' ');
            int CodPeça2 = int.Parse(vetor[0]);
            int Unidade2 = int.Parse(vetor[1]);
            double ValorUnidade2 = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            double Calc1 = Unidade1 * ValorUnid1;
            Console.WriteLine($"Valor do primeiro produto R${Calc1.ToString("F2",CultureInfo.InvariantCulture)} Reais");
            double Calc2 = Unidade2 * ValorUnidade2;
            Console.WriteLine($"Valor do produto 2 R$ {Calc2.ToString("F2", CultureInfo.InvariantCulture)} Reais");

            double Res = Calc1 + Calc2;


            Console.WriteLine($"Valor a ser pago é de R$ {Res.ToString("F2", CultureInfo.InvariantCulture)} Reais ");

        }
    }
}
