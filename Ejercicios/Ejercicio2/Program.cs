using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int respuestaOperacion = 0;
            int opcion = 0;

            Console.WriteLine("Escribe el primer número:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número:");
            b = Int32.Parse(Console.ReadLine());

            while (opcion == 0 || opcion > 4)
            {
                Console.WriteLine("Ingresa la opción que quieres realizar:");
                Console.WriteLine("1. Sumar (+).\n2. Resta(-)\n3. Multiplicar(*)\n4. División");
                Console.WriteLine("Escoge una de las opciones, escribiendo su número correspondiente:");
                opcion = Int32.Parse(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    respuestaOperacion = a + b;
                    Console.WriteLine($"La suma de los numeros {a} y {b} es: {respuestaOperacion}");
                    break;
                case 2:
                    respuestaOperacion = a - b;
                    Console.WriteLine($"La resta de los numeros {a} y {b} es: {respuestaOperacion}");
                    break;
                case 3:
                    respuestaOperacion = a * b;
                    Console.WriteLine($"El producto de los numeros {a} y {b} es: {respuestaOperacion}");
                    break;
                case 4:
                    respuestaOperacion = a / b;
                    Console.WriteLine($"La división de los numeros {a} y {b} es: {respuestaOperacion}");
                    break;
                default:
                    Console.WriteLine("Esta operación no esta disponible");
                    break;
            }
        }
    }
}
