using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Ejercicio
{
    internal class Archivo : IComponente
    {
        public string Nombre { get; set; }
        public string Ruta { get; set; } = "";

        public Archivo(string nombre)
        {
            this.Nombre = nombre;
        }

        public void Eliminar()
        {
            Console.WriteLine($"Se eliminó el archivo {this.Nombre}");
        }

        public void Mover(string destino)
        {
            Console.WriteLine($"Se movió el archivo {this.Nombre} a {destino}");
        }

        public override string ToString()
        {
            return $"Archivo: {this.Nombre}, ubicado en {this.Ruta}";
        }
    }
}
