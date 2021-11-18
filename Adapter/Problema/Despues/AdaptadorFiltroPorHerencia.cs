using Adapter.Problema.FiltrosExternos;

namespace Adapter.Problema.Despues
{
    internal class AdaptadorFiltroPorHerencia : FiltroSepia, IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            Inicializar();
            UsarFiltro(imagen);
        }
    }
}
