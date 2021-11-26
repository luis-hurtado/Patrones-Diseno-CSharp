using System;

namespace Proxy.Demo.Despues
{
    internal class EBook : IEBook
    {
        string nombreArchivo;

        public EBook(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            Cargar();
        }

        public string NombreArchivo { get { return nombreArchivo; } }

        private void Cargar()
        {
            Console.WriteLine("Cargando el archivo : " + nombreArchivo);
        }

        public void Mostrar()
        {
            Console.WriteLine("Mostrando el libro correspondiente al archivo : " + nombreArchivo);
        }

    }
}
