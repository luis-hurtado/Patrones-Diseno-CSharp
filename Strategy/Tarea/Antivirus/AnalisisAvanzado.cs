namespace Strategy.Tarea.Antivirus
{
    public abstract class AnalisisAvanzado : IEstrategia
	{

		public void Analizar()
		{
			Iniciar();
			AnalizarMemoria();
			AnalizarKeyloggers();
			AnalizarRootKits();
			DescomprimirZip();
			Detener();
		}

		internal abstract void Iniciar();

		internal abstract void AnalizarMemoria();

		internal abstract void AnalizarKeyloggers();

		internal abstract void AnalizarRootKits();

		internal abstract void DescomprimirZip();

		internal abstract void Detener();
	}
}
