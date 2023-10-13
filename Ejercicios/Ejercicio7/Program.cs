namespace Ejercicio7
{
    public class Program
    {
        //7. Cree un programa que pida al usuario un número y calcula su factorial (el producto de todos los enteros positivos menores o iguales al número).
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