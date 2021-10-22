namespace Objetos.Parte3
{
	public interface IVivientes
	{

		// No se utiliza la palabra reservada abstract
		// sin embargo todos los metodos son abstract por defecto

		string Nombre {set;get;}


		double? Altura {set;get;}


		double? Peso {set;get;}


		string ComidaFavorita {set;get;}


		double? Velocidad {set;get;}


		string Sonido {set;get;}


	}

}