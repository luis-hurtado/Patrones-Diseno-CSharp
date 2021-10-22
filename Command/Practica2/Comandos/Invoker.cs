using System.Collections.Generic;

namespace Command.Practica2.Comandos
{

	public class Invoker
	{

		private List<IOperacion> operaciones = new List<IOperacion>();

		public virtual void RecibirOperacion(IOperacion operacion)
		{
            operaciones.Add(operacion);
		}

		public virtual void RealizarOperaciones()
		{
            operaciones.ForEach(x => x.Ejecutar());
            operaciones.Clear();
		}

	}

}