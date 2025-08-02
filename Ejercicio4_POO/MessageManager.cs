using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO
{
    internal class MessageManager
    {
        private Test1 test1 = new Test1(); //se crea un campo para guardar la instancia
        private Test2 test2 = new Test2();
        
        public MessageManager()
        {
            test1 = new Test1(); //se instancia en el constructor
            test2 = new Test2();
            test1.PrintMessage("Plus Ultra desde Test 1");
            test2.PrintMessage("Plus Ultra desde Test 2");
            //test1.InvertMessage("Plus Ultra desde Test 2 invertido");
            //test2.InvertMessage("Plus Ultra desde Test 2");
        }
    }
}
