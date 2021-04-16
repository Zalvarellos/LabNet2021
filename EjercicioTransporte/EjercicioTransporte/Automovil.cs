using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
	public class Automovil : Transporte
	{
		private string nombreAuto;

		public Automovil(int cantPasajeros, string nombre) : base(cantPasajeros)
		{
			nombreAuto = nombre;
		}

		public override void Avanzar()
		{
			Console.WriteLine($"{nombreAuto} esta en Movimiento!");
		}

		public override void Detenerse()
		{
			Console.WriteLine($"{nombreAuto} se Detuvo!");
		}

		public override string ToString()
		{
			return nombreAuto + " : " + Convert.ToString(ObtenerPasajeros()) + " Pasajeros ";
		}
	}
}
