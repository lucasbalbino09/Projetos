using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretoria Resp = new Diretoria();

            Console.Write("Nome do aluno: ");
            Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Resp.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Resp.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Resp.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + Resp.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (Resp.Aprovacao())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado Faltam " + Resp.ResultFim().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
