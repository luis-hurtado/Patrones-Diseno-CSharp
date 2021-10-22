using System;
using System.Threading;

namespace Strategy.Tarea.Antivirus
{
	public class AntivirusAvanzado : AnalisisAvanzado
	{

        internal override void Iniciar()
		{
			Console.WriteLine("Antivirus Avanzado - Análisis iniciado");
		}

		internal override void AnalizarMemoria()
		{
			try
			{
				Console.WriteLine("Analizando Memoria RAM...");
				Thread.Sleep(1000);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		internal override void AnalizarKeyloggers()
		{
			try
			{
				Console.WriteLine("Analizando en busca de Keyloggers...");
				Thread.Sleep(1000);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		internal override void AnalizarRootKits()
		{
			try
			{
				Console.WriteLine("Analizando en busca de RootKits...");
				Thread.Sleep(1500);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		internal override void DescomprimirZip()
		{
			try
			{
				Console.WriteLine("Analizando archivos zip...");
				Thread.Sleep(2000);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		internal override void Detener()
		{
			Console.WriteLine("Antivirus Avanzado - Análisis finalizado");
		}

	}
}
