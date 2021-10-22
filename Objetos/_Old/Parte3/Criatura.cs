namespace Objetos.Parte3
{
	public abstract class Criatura
	{
		// los campos protegidos son como las campos privados
		// excepto que otras clases pueden heredarlos
		protected internal string nombre;
		protected internal int altura;
		protected internal string sonido;

		// Metodos
		public abstract string Nombre {set;get;}


		public abstract int Altura {set;get;}


	}

}