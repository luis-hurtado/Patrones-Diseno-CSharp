using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_Abstractas
{
    public class Jirafa : Criatura
    {
		public override string Nombre
		{
			set
			{
				nombre = value;

			}
			get
			{
				return nombre;
			}
		}


		public override int Altura
		{
			set
			{
				altura = value;
			}
			get
			{
				return altura;
			}
		}

		public override void EstablecerNombre(string nombre)
        {
			this.nombre = "La jirafa " + nombre;
            Console.WriteLine("mi nuevo nombre es:" + nombre);
        }
    }
}
