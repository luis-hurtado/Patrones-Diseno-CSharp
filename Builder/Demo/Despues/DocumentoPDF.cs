using System;

namespace Builder.Demo.Despues
{
    internal class DocumentoPDF
    {
        public void AgregarPagina(string texto)
        {
            Console.WriteLine("Agregando una pagina al documento PDF");
            Console.WriteLine("TEXTO: " + texto);
        }
    }
}
