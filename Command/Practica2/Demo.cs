using Command.Practica2.Comandos;

namespace Command.Practica2
{
	

	public class Demo
	{

		internal static void Ejecutar()
		{
			Cuenta cuenta = new Cuenta(100501, 200);

			IOperacion opDepositar = new OperacionDeposito(cuenta, 100);
			IOperacion opRetirar = new OperacionRetiro(cuenta, 50);

			Invoker cajero = new Invoker();
			cajero.RecibirOperacion(opDepositar);
			cajero.RecibirOperacion(opRetirar);

			cajero.RealizarOperaciones();
		}

	}

}