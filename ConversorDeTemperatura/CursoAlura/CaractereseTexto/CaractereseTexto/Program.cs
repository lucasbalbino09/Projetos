using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaractereseTexto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("executando o Projeto 5 - Caracteres e Textos ");

            char Letra = 'a';
            Console.WriteLine(Letra);

            Letra = (char)65;
            Console.WriteLine(Letra);

            Letra = (char)(65 + 1);
            Console.WriteLine(Letra);

            Letra = (char)(86 + 1);
            Console.WriteLine(Letra);


            string PrimeiraFrase = "Alura - curso de tecnologia ";
            Console.WriteLine(PrimeiraFrase + 2022);

            String vazia = "";
            Console.WriteLine(vazia);

            string cursos = @"Cursos Disponiveis
- go
- c#
- Python
- Java";

            Console.WriteLine(cursos);

            Console.WriteLine("Aperte enter para Finalizar o programa!");
            Console.ReadLine();

        }
    }
}
