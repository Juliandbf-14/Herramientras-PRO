namespace Ejercicio8
{
    public class Program
    {
        // 8. Cree un programa que pida al usuario una temperatura en grados Celsius y muestra su equivalente en grados Fahrenheit usando la fórmula: F = C * 9/5 + 32.
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