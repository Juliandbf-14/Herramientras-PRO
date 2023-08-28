// 4. Imprima los números del 1 al 10 en orden ascendente
// 
using System;

namespace Ejercicio1.Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Numeros del 1 al 10 de forma descendente");
            for (int i = 10; i >= 1; --i)
            {
                Console.WriteLine(i);
            }
        }
    }
}