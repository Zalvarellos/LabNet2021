using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
	public abstract class Transporte
	{
		private int pasajeros;

		public Transporte(int cantPasajeros)
		{
			this.pasajeros = cantPasajeros;
		}

		public abstract void Avanzar();

		public abstract void Detenerse();

		public int ObtenerPasajeros()
		{
			return pasajeros;
		}

	}
}
