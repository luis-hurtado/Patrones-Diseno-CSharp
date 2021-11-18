namespace Adapter.Problema.Antes
{
    internal class VistaImagen
    {
        private Imagen imagen;

        public VistaImagen(Imagen imagen)
        {
            this.imagen = imagen;
        }

        public void Aplicar(IFiltro filtro)
        {
            filtro.Aplicar(imagen);
        }
    }
}
