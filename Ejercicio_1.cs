/*Ejercicio 1: Impresión de Números Pares


Escribe un programa
que muestre los números pares del 2 al 20. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("identificar los numeros pares del 2 al 20");
            for (int i = 2; i <= 20; i = i + 2)  {

                Console.WriteLine(i);
            }
            Console.Read();

        }
            
                 
    }
}

