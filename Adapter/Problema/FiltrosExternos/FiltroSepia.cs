using System;

namespace Adapter.Problema.FiltrosExternos
{
    internal class FiltroSepia
    {
        string filtro;

        public void Inicializar()
        {
            filtro = "Aplicando el filtro de terceros a la imagen - Sepia";
        }

        public void UsarFiltro(Imagen imagen)
        {
            Console.WriteLine(filtro);
        }

    }
}
