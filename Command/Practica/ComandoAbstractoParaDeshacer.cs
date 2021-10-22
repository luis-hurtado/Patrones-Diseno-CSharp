namespace Command.Practica
{
	/// <summary>
	/// El propósito de esta clase es asegurarse de que todos los comandos que se pueden deshacer 
	/// tienen un VideoEditor y un Historial. Además, cada vez que se ejecuta un comando, es empujado en la historia. 
	/// De esta manera, no tenemos que recordar para almacenar cada comando individual en el historial.
	/// </summary>
	public abstract class ComandoAbstractoParaDeshacer : IComandoParaDeshacer
	{
		protected internal VideoEditor _videoEditor;
		protected internal Historial _historial;

		public ComandoAbstractoParaDeshacer(VideoEditor videoEditor, Historial historia)
		{
			this._videoEditor = videoEditor;
			this._historial = historia;
		}

		public virtual void Ejecutar()
		{
			// Otra aplicación del patrón del método de la plantilla. 
			// Este método es la definición de una plantilla para la ejecución de comandos.
			ImplementaEjecutar();

			_historial.Push(this);
		}

		public abstract void Deshacer();

		protected internal abstract void ImplementaEjecutar();
	}

}