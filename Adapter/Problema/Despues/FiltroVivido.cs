using System;

namespace Adapter.Problema.Despues
{
    internal class FiltroVivido : IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            Console.WriteLine("Se aplicó el filtro vivido");
        }
    }
}
