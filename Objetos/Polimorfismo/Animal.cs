using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Polimorfismo
{
    internal abstract class Animal
    {

        private string nombre;
        private double altura;
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

        public abstract void Jugar();
    }
}