using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO
{
    internal class Test2: AbstractSample
    {
        public override void PrintMessage(string message) // método printmessage imprime message con mayús y minús invertidas
        {
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

            Console.WriteLine(resultado);
        }
    }
}
