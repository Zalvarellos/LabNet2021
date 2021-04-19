using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Exceptions
{
    public class LogicException : Exception
    {

        public LogicException() : base("Error de Excepcion Logica!")
        {

        }

        public static void ThrowAnException()
        {
            throw new ArgumentException();
        }
    
    }
}
