namespace Mediator.Tarea
{
    public abstract class Usuario
    {
        protected ISalaDeChatMediator mediador;
        protected string nombre;

        public Usuario(ISalaDeChatMediator mediator, string nombre)
        {
            this.mediador = mediator;
            this.nombre = nombre;
        }

        public abstract void Enviar(string mensaje);
        public abstract void Recibir(string mensaje);

        public string UserName => nombre;
    }
}
