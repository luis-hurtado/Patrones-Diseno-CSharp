using System;

namespace Objetos.Parte3
{
	public class Perro : Animal
	{

		public Perro() : base()
		{
			Sonido = "Guauu, Guau";
		}

		public virtual void HacerHuecos()
		{
			Console.WriteLine("hoyo cavado...");
		}

		public virtual void CambiarValorVariable(int randNum)
		{
			randNum = 12;
			Console.WriteLine("El valor de randNum en el metodo es: " + randNum);
		}
	}
}