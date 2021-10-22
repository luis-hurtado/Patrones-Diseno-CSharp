using System;

namespace Objetos.Clases_Abstractas
{
    public abstract class Criatura
    {
        // Campos
        // No existen campos abstractos

        // los campos protegidos son como las campos privados
        // excepto que otras clases pueden heredarlos
        protected internal string nombre;
        protected internal int altura;
        protected internal string sonido;

        // Propiedades
        public abstract string Nombre { set; get; }


        public abstract int Altura { set; get; }

        // Metodos
        public abstract void EstablecerNombre(String nombre);

        // No todos los metodos necesitan ser abstractos
        public String ObtenerTipo()
        {
            return this.GetType().Name;
        }

        // Puede contener metodos estaticos
        public static void MostrarVersion()
        {
            Console.WriteLine("Criatura v.1.0.0.1");
        }
    }
}
