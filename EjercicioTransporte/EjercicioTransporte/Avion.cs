using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
	public class Avion : Transporte
	{
		private string nombreAvion;

		public Avion(int cantPasajeros, string nombre) : base(cantPasajeros)
		{
			nombreAvion = nombre;
		}
		public override void Avanzar()
		{
			Console.WriteLine($"El Avion {nombreAvion} esta en plento vuelo!");
		}

		public override void Detenerse()
		{
			Console.WriteLine($"El Avion {nombreAvion} esta aterrizando!");
		}

		public override string ToString()
		{
			return nombreAvion + " : " + Convert.ToString(ObtenerPasajeros()) + " Pasajeros ";
		}
	}
}