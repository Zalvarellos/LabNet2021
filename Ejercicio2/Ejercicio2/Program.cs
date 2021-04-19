using Ejercicio2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Punto 1.");
                int numero = Convert.ToInt32(Console.ReadLine());
                numero.DividirPorCero();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finalizo la operacion de punto 1...");
                Console.Read();
            }

            Console.WriteLine("Punto 2.");

            Exceptions.Exceptions.ThrowException();
            
            try
            {
                Console.WriteLine("Punto 3.");
                Exceptions.LogicException.ThrowAnException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la excepcion: '{ex.Message}'");
                Console.WriteLine($"Tipo de Exception: {ex.GetType()}");

            }


            try
            {
                Console.WriteLine("Punto 4.");
                Exceptions.Exceptions.ThrowLogicException();
            }
            catch (Exceptions.LogicException ex)
            {

                Console.WriteLine($"Se capturo la Exception, su mensaje es: {ex.Message}");
                Console.Read();
            }
            finally
            {
                Console.WriteLine("Finalizo la operacion de punto 3...");
                Console.Read();
            }
        } 
    }
}
