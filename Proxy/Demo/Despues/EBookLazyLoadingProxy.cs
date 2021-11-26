namespace Proxy.Demo.Despues
{
    internal class EBookLazyLoadingProxy : IEBook
    {
        private readonly string nombreArchivo;
        private EBook eBook;

        public string NombreArchivo => nombreArchivo;

        public EBookLazyLoadingProxy(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }

        public void Mostrar()
        {
            if(eBook == null)
                eBook = new EBook(nombreArchivo);
            eBook.Mostrar();
        }
    }
}
