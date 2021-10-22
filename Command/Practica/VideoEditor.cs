namespace Command.Practica
{
	public class VideoEditor
	{
        public string Texto { get; set; }

        public float Contraste { get; set; } = 0.5f;				

		public override string ToString()
		{
			return "VideoEditor{" + "contraste=" + Contraste + ", texto='" + Texto + '\'' + '}';
		}
	}

}