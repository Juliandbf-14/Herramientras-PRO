using System;

namespace Ejercicio9
{
    public class Program
    {
        // 9. Cree un programa que pida al usuario un número y verifica si es primo (solo divisible por 1 y por sí mismo).
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
                    // Si devuelve falso, significa que no es primo
                    return false;
                }
            }
            // Si devuelve verdadero, significa que es primo
            return true;
        }
    }
}
