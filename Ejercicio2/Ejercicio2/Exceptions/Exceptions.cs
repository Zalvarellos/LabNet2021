using Ejercicio2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Exceptions
{
    public class Exceptions
    {
        public static void ThrowLogicException()
        {
            throw new LogicException();
        }



        public static void ThrowException()
        {
            try
            {
                Console.WriteLine("Punto 3.");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                int numero2 = Convert.ToInt32(Console.ReadLine());

                ExtensionMethods.DivisionEntreDosNumeros(numero1, numero2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                Console.Read(); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Tu division mato a krillin...");
                Console.WriteLine("Mensaje Original: " + ex.Message);
                Console.Read();
            }
            finally
            {
                Console.WriteLine("Finalizo la operacion de punto 2...");
                Console.Read();
            }
        }
    }
}
