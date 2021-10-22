using System.Collections.Generic;

namespace Command.Practica
{

	public class Historial
	{
		private Queue<IComandoParaDeshacer> comandos = new Queue<IComandoParaDeshacer>();

		public virtual void Push(IComandoParaDeshacer command)
		{
			comandos.Enqueue(command);
		}

		public virtual IComandoParaDeshacer Pop()
		{			
			return comandos.Dequeue();
		}

		public virtual int Size()
		{
			return comandos.Count;
		}
	}

}