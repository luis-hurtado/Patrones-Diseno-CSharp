namespace Mediator.Observer
{
    public class TextBox : ManejadorEventos
    {
        private string texto;

        public string Texto
        {
            get => texto; set
            {
                texto = value;
                ProcesarEvento();
            }
        }
    }
}
