using System;

namespace Strategy.Despues
{
    public class FiltroBlancoNegro : IFiltro
    {
        public void Aplicar()
        {
            Console.WriteLine("Se aplico el filtro Blanco y Negro a la imagen");
        }
    }
}
