using System;
using System.Threading;

namespace Strategy.Tarea.Antivirus
{
	public class AntivirusSimple : AnalisisSimple
	{

		internal override void Iniciar()
		{
			Console.WriteLine("Antivirus Simple - Análisis simple iniciado");
		}

		internal override void SaltarZip()
		{
			try
			{
				Console.WriteLine("Analizando...");
				Thread.Sleep(2500);
				Console.WriteLine("No se pudo analizar archivos con extensión '.zip'");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		internal override void Detener()
		{
			Console.WriteLine("Antivirus Simple - Análisis simple finalizado");
		}

	}
}
