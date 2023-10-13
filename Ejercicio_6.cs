/* Ejercicio 6: Pare e Impar


Escribe un programa que diga si un número
es par o impar.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("intruducir un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine(" el numero" + numero + "es par");
            }
            else
            {
                Console.WriteLine("El numero" + numero + "es impar");
            }
            Console.ReadKey();
        }

    }

}
