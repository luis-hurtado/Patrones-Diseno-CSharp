using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Acoplamiento
{
    class Usuario
    {
        private string nombre;

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        internal void Saludar()
        {
            Console.WriteLine("Hola "+nombre);
        }
    }
}
