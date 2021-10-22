namespace Mediator.Tarea
{
    public interface ISalaDeChatMediator
    {
        string NombreGrupo { get; }

        void RegistrarUsuario(Usuario usuario);

        void EnviarMensaje(Usuario destinatario, string mensaje);
    }
}
