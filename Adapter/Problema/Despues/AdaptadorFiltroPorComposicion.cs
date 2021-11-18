using Adapter.Problema.FiltrosExternos;

namespace Adapter.Problema.Despues
{
    internal class AdaptadorFiltroPorComposicion : IFiltro
    {
        private FiltroSepia filtroTerceros;

        public AdaptadorFiltroPorComposicion(FiltroSepia filtroTerceros)
        {
            this.filtroTerceros = filtroTerceros;
        }

        public void Aplicar(Imagen imagen)
        {
            filtroTerceros.Inicializar();
            filtroTerceros.UsarFiltro(imagen);
        }
    }
}
