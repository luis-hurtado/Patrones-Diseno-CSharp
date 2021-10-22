namespace Command.Practica
{
	public class ComandoDeshacer : IComando
	{
		private Historial historial;

		public ComandoDeshacer(Historial historial)
		{
			this.historial = historial;
		}

		public virtual void Ejecutar()
		{
			if (historial.Size() > 0)
			{
				historial.Pop().Deshacer();
			}
		}
	}

}