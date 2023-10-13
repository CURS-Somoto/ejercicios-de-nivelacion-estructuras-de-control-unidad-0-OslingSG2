/*Ejercicio 3: Numero primo


Escribe un
programa que determine si un número dado es primo o no.*/


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
            int limite;
            int aux;
            string numerosprimos = "2";
            int numEvaluar;
            int ctrlNoEsprimo;

            Console.WriteLine("Favor ingresar el limite hasta donde se calcularan los numeros primos");
            limite = Convert.ToInt16( Console.ReadLine());

            for (int i = 3; i <= limite; i++)
            {
                numEvaluar = i;
                aux = 2;
                ctrlNoEsprimo = 0;
                while (aux < numEvaluar && ctrlNoEsprimo == 0)
                {

                    int operacion = numEvaluar % aux;
                    if (operacion != 0)
                    {
                        aux += 1;
                        //aux++
                    }
                    else
                    {
                        ctrlNoEsprimo = 1;
                    }

                }
                if (ctrlNoEsprimo <= 0)
                {
                    numerosprimos = numerosprimos + "," + numEvaluar;
                }
            }
            Console.WriteLine("Los numeros primos encontrados son: " + numerosprimos);
            Console.ReadLine();

        }
    }
}
