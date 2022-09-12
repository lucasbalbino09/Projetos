using System;
using System.Globalization;
namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos Res = new Alunos();
            

            Console.Write("Nome do Aluno: ");
            Res.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Res.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Res.nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Res.nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + Res.CalculoDasNotas().ToString("F2", CultureInfo.InvariantCulture));

            if (Res.Condicao())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram " +
                    $"{Res.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)}" 
                    + " PONTOS");
            }

            Console.ReadLine();
        }
    }
}
