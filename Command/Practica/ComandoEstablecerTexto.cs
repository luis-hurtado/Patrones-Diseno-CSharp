namespace Command.Practica
{
	public class ComandoEstablecerTexto : ComandoAbstractoParaDeshacer
	{
		private string texto;

		public ComandoEstablecerTexto(string texto, VideoEditor videoEditor, Historial historial) : base(videoEditor, historial)
		{

			this.texto = texto;
		}

		protected internal override void ImplementaEjecutar()
		{
			_videoEditor.Texto = texto;
		}

		public override void Deshacer()
		{
			_videoEditor.Texto = string.Empty;
		}
	}

}