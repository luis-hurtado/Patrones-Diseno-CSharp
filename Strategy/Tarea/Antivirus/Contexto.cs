using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Tarea.Antivirus
{
	public class Contexto
	{

		private IEstrategia estrategia;

		public Contexto(IEstrategia estrategia)
		{
			this.estrategia = estrategia;
		}

        public IEstrategia Estrategia { get => estrategia; set => estrategia = value; }

        public void Ejecutar()
		{
			estrategia.Analizar();
		}

	}
}
