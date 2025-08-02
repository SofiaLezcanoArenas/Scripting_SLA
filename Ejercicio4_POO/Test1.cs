using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO
{
    internal class Test1: AbstractSample
    {
        public override void PrintMessage(string message) // método printmessage imprime message
        {
            Console.WriteLine(message);
        }

        public override void InvertMessage(string message)
        {
            // cambio mayús por minús

            string resultado = "";
            
            foreach (char c in message)
            {
                if (char.IsLower(c))
                {
                    resultado += char.ToUpper(c); // minúscula → mayúscula
                }
                else if (char.IsUpper(c))
                {
                    resultado += char.ToLower(c); // mayúscula → minúscula
                }
                else
                {
                    resultado += c; // deja números, espacios y símbolos igual
                }
            }

            base.InvertMessage(message); // con esto se llama el funcionamiento base que tenía el método original
        }
    }
}
