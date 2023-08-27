// 3. Crear un programa que le pida al usuario un número e 
// imprime su tabla de multiplicar del 1 al 10.
using System;

namespace Ejercicio1.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingresar un numero:");
            numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"La tabla de multiplicar del número {numero} es:");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = " + numero * i);
            }
        }
    }
}