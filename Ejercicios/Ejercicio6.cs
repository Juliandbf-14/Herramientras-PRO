
using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un número: ");
            numero = Int32.Parse(Console.ReadLine());

            if(numero % 2 == 0){
                Console.WriteLine("El número seleccionado es par. ");
            } else {
                Console.WriteLine("El número seleccionado es impar.");
            }
        }
    }
}
