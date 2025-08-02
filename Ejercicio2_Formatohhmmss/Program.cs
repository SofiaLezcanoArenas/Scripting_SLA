namespace Ejercicio2_Formatohhmmss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad de segundos");
            int segundos = Convert.ToInt32(Console.ReadLine());

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60; //lo que sobra que ya no cubre horas completas, se divide entre 60 para encontrar los minutos
            int segundosRest = segundos % 60; //lo que ya sobra de los minutos son los segundos

            Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundosRest:D2}"); //La d puede ser minúscula.
                                                                             //Lo que hace d2 es mostrar los números siempre de 2 dígitos
        }
    }
}
