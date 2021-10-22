using System;

namespace Strategy.Despues
{
    public class FiltroAltaResolucion : IFiltro
    {
        public void Aplicar()
        {
            Console.WriteLine("Se aplico el filtro de Alta Resolución a la imagen");
        }
    }
}
