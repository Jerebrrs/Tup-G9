using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Iterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1=0, x2=0;

            Console.Write("Ingrese la cantidad de terminos que tendra la serie de Fibonacci: ");
            int cantTerminos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantTerminos; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                        x1 = 0;
                        x2 = i;
                        break;
                    default:
                        int x3 = x2 + x1;
                        x1 = x2;
                        x2 = x3;
                        break;

                }
                Console.WriteLine(x2);
            }

            Console.WriteLine();
        }
    }
}
