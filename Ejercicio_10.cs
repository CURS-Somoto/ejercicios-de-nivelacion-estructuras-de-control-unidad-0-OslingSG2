/*
Ejercicio 10: Determinar si un Número es
Positivo, Negativo o Cero


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrse numero: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero == 0)
            {
                Console.Write("El numero" + numero + "es un numero cero");
            }
            else if(numero > 0)
            {
                Console.Write("el numero" + numero + "es un numero positivo.");
            }
            else
            {
                Console.Write("el numero" + numero + "es un numero negativo.");
            }
            Console.ReadKey();
        }
    }
}
