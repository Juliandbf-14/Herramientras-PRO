using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int suma = 0;

            Console.WriteLine("Escribe el primer numero que quieres sumar:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero que quieres sumar:");
            b = Int32.Parse(Console.ReadLine());
            suma = a + b;
            Console.WriteLine($"La suma del número {a} y {b} es:{suma}");
        }
    }
}
