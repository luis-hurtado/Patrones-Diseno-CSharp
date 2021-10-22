using System;

namespace Mediator.Tarea
{
    public class Demo
    {
        public static void Ejecutar()
        {
            ISalaDeChatMediator mediator = new SalaDeChat("Patrones de diseño con C#");

            Console.WriteLine($"GRUPO '{mediator.NombreGrupo}' HA SIDO CREADO!\n");

            Usuario jorge = new UsuarioConcreto(mediator, "Jorge");
            Usuario maria = new UsuarioConcreto(mediator, "María");
            Usuario carlos = new UsuarioConcreto(mediator, "Carlos");

            mediator.RegistrarUsuario(jorge);
            mediator.RegistrarUsuario(maria);
            mediator.RegistrarUsuario(carlos);

            Console.WriteLine();

            maria.Enviar("Hola a todos!");
            Console.WriteLine();
            carlos.Enviar("Wow!, Me encanta este grupo!");
            Console.WriteLine();
            jorge.Enviar("Hola María y Carlos!");
        }
    }
}
