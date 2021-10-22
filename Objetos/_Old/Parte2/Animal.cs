using System;

namespace Objetos.Parte2
{
    public class Animal
    {
        private string nombre;
        private double altura;
        // private int peso;
        private string sonido;

        public virtual string Nombre
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


        public virtual double Altura
        {
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("El peso debe ser mayor a 0.");
                }
            }
            get
            {
                return altura;
            }
        }


        public virtual string Sonido
        {
            set
            {
                sonido = value;
            }
            get
            {
                return sonido;
            }
        }


    }
}