namespace Command.Practica2.Comandos
{
	public class OperacionRetiro : IOperacion
	{

		private readonly Cuenta cuenta;
		private readonly double monto;

		public OperacionRetiro(Cuenta cuenta, double monto)
		{
			this.cuenta = cuenta;
			this.monto = monto;
		}

		public void Ejecutar()
		{
			this.cuenta.Retirar(this.monto);
		}

	}

}