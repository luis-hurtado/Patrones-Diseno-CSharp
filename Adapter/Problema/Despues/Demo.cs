using Adapter.Problema.FiltrosExternos;

namespace Adapter.Problema.Despues
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var visor = new VistaImagen(new Imagen());
            visor.Aplicar(new FiltroVivido());
            visor.Aplicar(new FiltroBlancoYNegro());
            // Solucion por composicion
            visor.Aplicar(new AdaptadorFiltroPorComposicion(new FiltroSepia()));
            // Solucion por herencia
            visor.Aplicar(new AdaptadorFiltroPorHerencia());
        }
    }
}
