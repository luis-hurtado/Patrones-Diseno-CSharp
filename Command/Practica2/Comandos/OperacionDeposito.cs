namespace Command.Practica2.Comandos
{
	public class OperacionDeposito : IOperacion
	{

		private readonly Cuenta cuenta;
		private readonly double monto;

		public OperacionDeposito(Cuenta cuenta, double monto)
		{
			this.cuenta = cuenta;
			this.monto = monto;
		}

        public void Ejecutar()
        {
			cuenta.Depositar(monto);
		}

	}

}