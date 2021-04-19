using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Extensions
{
    public static class ExtensionMethods
    {
        public static void DividirPorCero(this int numero)
        {
            int resultado = numero / 0;
        }

        public static void DivisionEntreDosNumeros(this int dividendo, int divisor)
        {
            int resultado = dividendo / divisor;

            Console.WriteLine("Resultado: " + resultado);
            Console.Read();
        }

    }
}
