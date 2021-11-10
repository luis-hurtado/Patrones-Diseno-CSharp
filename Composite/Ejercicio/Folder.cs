using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Ejercicio
{
    internal class Folder : IComponente
    {
        private List<IComponente> contenidos = new List<IComponente>();
        public string Nombre { get; set; }
        public string Ruta { get; set; } = @"C:\";

        public Folder(string nombre, string ruta)
        {
            this.Nombre = nombre;
            this.Ruta = ruta;
        }
        public Folder(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AgregarContenido(IComponente item)
        {
            if(!contenidos.Contains(item))
            {
                item.Ruta = $@"{this.Ruta}\{this.Nombre}";
                contenidos.Add(item);
            }
        }

        public void Eliminar()
        {
            Console.WriteLine($"Comenzando eliminacion del folder {this.Nombre}");
            foreach (var item in contenidos)
            {
                item.Eliminar();
            }
            Console.WriteLine($"Finalizo eliminacion del folder {this.Nombre}");
        }

        public void Mover(string destino)
        {
            Console.WriteLine($"Comenzando a mover el folder {this.Nombre}");
            this.Ruta = destino;
            
            foreach (var item in contenidos)
            {
                item.Mover($@"{this.Ruta}\{this.Nombre}");
            }
            Console.WriteLine($"Finalizo de mover del folder {this.Nombre}");
        }

        public override string ToString()
        {
            return $@"Folder: {this.Ruta}\{this.Ruta}";
        }
    }
}
