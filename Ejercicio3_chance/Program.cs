using System.Linq;
namespace Ejercicio3_chance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int apuesta = 1000;

            do
            {
                Console.WriteLine("Ingrese el número de su chanche");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1000 || num >10000)
                {
                    Console.WriteLine("ERROR\n Ingrese un número de 4 cifras");
                }

            } while (num < 1000 || num > 10000); // para evitar pasar un número que no sea de 4 cifras
            
            Random aleatorio = new Random(); // se crea un número aleatorio

            int resultado = aleatorio.Next(1000, 10000); // 1000 incluido, 10000 excluido (número de 4 cifras)
            //int resultado = 1234; //prueba
            bool ganador = Gana(num, resultado);
            int premio = DeterminarPremio(num, resultado, apuesta);

            if (ganador) // impresión de prueba
            {
                Console.WriteLine("Felicidades, ha acertado por completo\nPremio: "+premio+"\nNúmero ganador: "+resultado);
            }
            else
            {
                if (premio > 0)
                {
                    Console.WriteLine("Casi ha conseguido adivinarlo\nNúmero ganador: "+resultado);
                    Console.WriteLine("Premio:" + premio);
                }
                else
                {
                    Console.WriteLine("Número ganador: " + resultado + "\nSigue intentando");
                    Console.WriteLine("Premio:" + premio);
                }
            }
        }

        static bool Gana(int num, int resultado)
        {
            if (num == resultado) // si el número elegido es igual al resultado
            {
                return true; // la persona gana
            }
            return false; // sino, no gana
        }

        static int DeterminarPremio(int num, int resultado, int apuesta)
        {

            if (num == resultado) // si son iguales
            {
                return apuesta * 4500; // se gana el premio mayor
            }

            if (num != resultado) // si no son iguales, hay que empezar a comparar cifra por cifra
            {
                // Convertimos los números a string
                string str1 = num.ToString();
                string str2 = resultado.ToString();

                var ostr1 = str1.OrderBy(c => c); //ordena los caracteres de menor a mayor y los guarda en una variable
                var ostr2 = str2.OrderBy(c => c);

                if (ostr1.SequenceEqual(ostr2)) //compara si son iguales
                {
                    return apuesta * 200;
                }

                if (str1[1] == str2[1] && str1[2] == str2[2] && str1[3] == str2[3])// primero revisa desde las 3 cifras
                {
                    return apuesta * 400;
                }
                if (str1[2] == str2[2] && str1[3] == str2[3]) //luego las 2 ultimas
                {
                    return (apuesta * 50);
                }
                if (str1[3] == str2[3]) //luego la última
                {
                    return apuesta * 5;
                }
            }
            return 0;
        }
    }
}
