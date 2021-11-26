using System.Collections.Generic;

namespace Proxy.Demo.Antes
{
    internal class Biblioteca
    {
        private Dictionary<string, EBook> libros = new Dictionary<string, EBook>();

        public void Agregar(EBook libro)
        {
            libros[libro.NombreArchivo] = libro;
        }

        public void AbrirLibro(string nombreArchivo)
        {
            libros[nombreArchivo]?.Mostrar();
        }

    }
}
