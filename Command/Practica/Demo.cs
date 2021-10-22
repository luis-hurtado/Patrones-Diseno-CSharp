using System;

namespace Command.Practica
{
	public class Demo
	{
		internal static void Ejecutar()
		{
			var editor = new VideoEditor();
			var historia = new Historial();

			var establecerTexto = new ComandoEstablecerTexto("Titulo del video", editor, historia);
			establecerTexto.Ejecutar();
			Console.WriteLine("TEXTO: " + editor);

			var establecerContraste = new ComandoEstablecerContraste(3, editor, historia);
			establecerContraste.Ejecutar();
			Console.WriteLine("CONTRASTE: " + editor);

			var undoCommand = new ComandoDeshacer(historia);
			undoCommand.Ejecutar();
			Console.WriteLine("DESHACER: " + editor);

			undoCommand.Ejecutar();
			Console.WriteLine("DESHACER: " + editor);

			undoCommand.Ejecutar();
			Console.WriteLine("DESHACER: " + editor);
		}
	}

}