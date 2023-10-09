using System;

namespace Ejercicios
{
    public class Ejercicio8
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese el número para verificar si es primo: ");
            numero = Int32.Parse(Console.ReadLine());

            if(EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} no es primo.");
            } else {
                Console.WriteLine($"El número {numero} es primo.");
            }
            
                        
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }
            // Es primo :)
            return true;
        }
    }
}
