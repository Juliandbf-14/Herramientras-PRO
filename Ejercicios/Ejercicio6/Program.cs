using System;

namespace Ejercicio6
{
    class Program
    {   
        // 6. Cree un programa que pida al usuario un número e indica si es par o impar.
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