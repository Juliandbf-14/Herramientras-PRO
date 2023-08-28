using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio8
    {
        static void Main(string[] args)
        {
            float celsius = 0;
            Console.WriteLine("Ingrese la temperatura en celsius (C) para calcular su equivalente en fahrenheit: ");
            celsius = Int32.Parse(Console.ReadLine());

            float fahrenheit = celsius * 9/5 + 32;
            Console.WriteLine($"Los grados celsius: {celsius} en fahrenheit son: {fahrenheit}");

        }
    }
}