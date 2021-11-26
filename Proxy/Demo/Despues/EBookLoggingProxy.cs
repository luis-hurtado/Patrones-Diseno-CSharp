using System;

namespace Proxy.Demo.Despues
{
    internal class EBookLoggingProxy : IEBook
    {
        private readonly string nombreArchivo;
        private EBook eBook;

        public string NombreArchivo => nombreArchivo;

        public EBookLoggingProxy(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }

        public void Mostrar()
        {
            if (eBook == null)
                eBook = new EBook(nombreArchivo);
            Console.WriteLine($"Guardamos log del archivo {nombreArchivo} antes de su ejecucion");
            eBook.Mostrar();
            Console.WriteLine($"Guardamos log del archivo {nombreArchivo} despues de su ejecucion");
        }
    }
}
