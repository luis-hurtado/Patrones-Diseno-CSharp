using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Problema.Antes
{
    internal class FiltroBlancoYNegro : IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            Console.WriteLine("Se aplicó el filtro B/N");
        }
    }
}
