﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_True_or_False
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 50, valor2 = 50;
            
            if (valor1 != valor2)
            {
                Console.WriteLine("A Operação feita é VERDADEIRA");
            }else if (valor1 == valor2)
            {
                Console.WriteLine("A operação CAIU NA 2 VERIFICAÇÃO");
            }
            else
            {
                Console.WriteLine("A operação feita é FALSA");

            }






















            Console.ReadKey();
        }
    }
}
