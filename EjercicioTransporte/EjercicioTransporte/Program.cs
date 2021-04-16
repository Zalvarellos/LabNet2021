using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>();

            Console.WriteLine("Agregar 5 Aviones: ");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"cantidadDePasajeros para avion{i}: ");
                string cantPasajeros = Console.ReadLine();
                transportes.Add(new Avion(Convert.ToInt32(cantPasajeros), $"Avion{i}"));
            }

            Console.WriteLine("Agregar 5 Autos: ");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"cantidadDePasajeros para Automovil{i}: ");
                string cantPasajeros = Console.ReadLine();
                transportes.Add(new Avion(Convert.ToInt32(cantPasajeros), $"Automovil{i}"));
            }

            foreach (var item in transportes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
