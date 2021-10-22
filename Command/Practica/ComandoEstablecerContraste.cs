namespace Command.Practica
{
	public class ComandoEstablecerContraste : ComandoAbstractoParaDeshacer
	{
		private float contrastePrevio;
		private float contraste;

		public ComandoEstablecerContraste(float contrast, VideoEditor videoEditor, Historial history) : base(videoEditor, history)
		{

			contrastePrevio = videoEditor.Contraste;
			contraste = contrast;
		}

		protected internal override void ImplementaEjecutar()
		{
			_videoEditor.Contraste = contraste;
		}

		public override void Deshacer()
		{
			_videoEditor.Contraste = contrastePrevio;
		}
	}

}