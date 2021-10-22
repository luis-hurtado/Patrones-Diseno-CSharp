using System;

namespace Command.Practica2.Comandos
{
	//Receiver/Request 
	public class Cuenta
	{

        private readonly int id;
		private double saldo;

		public Cuenta(int id, double saldo)
		{
			this.id = id;
			this.saldo = saldo;
		}

		public virtual void Retirar(double monto)
		{
			saldo -= monto;
            Console.WriteLine($"[COMANDO RETIRAR] Cuenta: {id} Saldo: {saldo}");
		}

		public virtual void Depositar(double monto)
		{
            saldo += monto;
			Console.WriteLine($"[COMANDO DEPOSITAR] Cuenta: {id} Saldo: {saldo}");
		}

	}

}