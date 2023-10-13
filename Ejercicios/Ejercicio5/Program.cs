using System;

namespace Ejercicio5
{
    class Program
    {   
        // 5. Escribe un programa que imprima los números del 10 al 1 en orden descendente.
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