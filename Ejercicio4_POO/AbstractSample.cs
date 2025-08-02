using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO
{
    internal abstract class AbstractSample
    {
        private string message = "";

        public abstract void PrintMessage(string message); //los métodos abstractos no pueden tener cuerpo. Su implementación queda pendiente para las clases que hereden
        
        public virtual void InvertMessage(string message)
        {
            string invertido = new string(message.Reverse().ToArray());
            Console.WriteLine(invertido);
        }
    }
}
