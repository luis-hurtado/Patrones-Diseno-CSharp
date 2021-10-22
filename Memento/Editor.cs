namespace Memento
{
    public class Editor
    {
        // FUNCIONES PROPIAS DEL EDITOR
        public string Contenido { get; set; }

        // FUNCIONES NECESARIAS PARA INTERACRUAR CON LOS ESTADOS
        public EstadoEditor CrearEstado()
        {
            return new EstadoEditor(Contenido);
        }

        public void RestaurarEstado(EstadoEditor estado)
        {
            Contenido = estado.Contenido;
        }

    }
}
