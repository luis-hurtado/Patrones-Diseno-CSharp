using System;
using System.Collections.Generic;

namespace Mediator.Tarea
{
    public class SalaDeChat : ISalaDeChatMediator
    {
        private string nombreGrupo = string.Empty;
        private List<Usuario> usuarios = new List<Usuario>();

        public SalaDeChat(string nombreGrupo) => this.nombreGrupo = nombreGrupo;

        public string NombreGrupo => nombreGrupo;

        public void RegistrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
            Console.WriteLine($"\t{usuario.UserName} (se ha unido al grupo '{nombreGrupo}'!)");
        }

        public void EnviarMensaje(Usuario destinatario, string mensaje)
        {
            foreach (var usuario in usuarios)
                if (usuario != destinatario)
                    usuario.Recibir(mensaje);
        }
    }
}
