namespace Mediator.Observer
{
    public class ListBox : ManejadorEventos
    {
        private string iTemSeleccionado;


        public string ITemSeleccionado
        {
            get => iTemSeleccionado;
            set
            {
                iTemSeleccionado = value;
                ProcesarEvento();
            }
        }

    }
}
