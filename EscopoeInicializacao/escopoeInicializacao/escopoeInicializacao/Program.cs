﻿using System;

namespace escopoeInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            
            if (preco > 100.00)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
