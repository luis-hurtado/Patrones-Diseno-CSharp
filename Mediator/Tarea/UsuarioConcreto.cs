using System;

namespace Mediator.Tarea
{
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(ISalaDeChatMediator mediator, string name) : base(mediator, name) { }

        public override void Recibir(string message) =>
            Console.WriteLine($"\t{nombre} (Mensaje Recibido) > {message}");

        public override void Enviar(string message)
        {
            Console.WriteLine($"{nombre} (Enviando Mensaje) > {message}\n");
            mediador.EnviarMensaje(this, message);
        }
    }
}
