using Adapter.Problema.FiltrosExternos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Problema.Antes
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var visor = new VistaImagen(new Imagen());
            visor.Aplicar(new FiltroVivido());
            visor.Aplicar(new FiltroBlancoYNegro());
            //Problema AQUI 
            //visor.Aplicar(new FiltroSepia());
        }
    }
}
