namespace Mediator.Ejercicio
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

        public bool EsVacio
        {
            get
            {
                return string.IsNullOrWhiteSpace(texto);
            }
        }
    }
}
