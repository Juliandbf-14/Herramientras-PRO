using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio7
    {
       static void Main(string[] args)
       {
            int numero = 0;
            Console.WriteLine("Ingrese el número para calcular su factorial: ");
            numero = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Factorial del número {numero}: ");
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine($"{numero } *  {i} = {numero * i}");
            }
       } 
    }
}