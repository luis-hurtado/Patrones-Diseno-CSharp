namespace Memento
{
    public class EstadoEditor
    {
        private readonly string contenido;

        public EstadoEditor(string contenido)
        {
            this.contenido = contenido;
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }
        }

    }
}
