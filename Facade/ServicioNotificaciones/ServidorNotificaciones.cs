using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;
using System;

namespace Facade.ServicioNotificaciones
{
    internal class ServidorNotificaciones
    {
        // Conectarnos al servidor
        public Conexion Conectar(string direccionIP)
        {
            return new Conexion(direccionIP);
        }
        // Autenticarse
        public AutenticacionPorToken Autenticarse(string idAplicacion, string llave)
        {
            return new AutenticacionPorToken(idAplicacion, llave);
        }

        // Enviar Mensaje
        public void EnviarMensaje(AutenticacionPorToken token, Mensaje mensaje, string destinatarios)
        {
            Console.WriteLine("Enviando el mensaje: " + mensaje.Contenido);
            Console.WriteLine("a: " + destinatarios);
            Console.WriteLine("usando el token valido: " + token.Token);
        }


    }
}
