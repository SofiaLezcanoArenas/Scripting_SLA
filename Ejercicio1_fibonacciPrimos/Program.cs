using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1_fibonacciPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido\n¿Cuántos números de la serie Fibonacci desea analizar?");
            int nesimo = Convert.ToInt32(Console.ReadLine());

            int[] serie = new int[nesimo];
            serie[0] = 0;
            serie[1] = 1;
            bool primo;

            for (int i = 2; i < nesimo; i++) 
            {
                serie[i] = serie[i - 1] + serie[i - 2];

                primo = NumPrimo(serie[i]);
                
                if (primo)
                {
                    Console.WriteLine(serie[i]);
                }
                
            }
        }
        static bool NumPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            if (numero == 2)
                return true;

            if (numero % 2 == 0)
                return false;

            for (int i = 3; i <= (int)Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) // % es el operador módulo (o residuo). Ejemplo: 10 % 3 → 1   (porque 10 dividido entre 3 es 3 y sobra 1)
                    return false; // Si tiene un divisor, no es primo
            }

            return true; // Si no encontró divisores, es primo
        }
    }
}
