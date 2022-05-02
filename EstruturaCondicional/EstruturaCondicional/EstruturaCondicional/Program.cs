using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Entre com um numero inteiro:");
            //int x = int.Parse(Console.ReadLine());


            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //} else
            //{
            //    Console.WriteLine("Impar!");
            //}

            Console.WriteLine("Que Horas São ?");
            int horas = int.Parse (Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine($"São {horas} Horas, Bom Dia..");
            } else if (horas < 18)
            {
                Console.WriteLine($"São {horas} Horas, Boa Tarde..");
            } else
            {
                Console.WriteLine("Boa Noite");
            }
            
        }
    }
}
