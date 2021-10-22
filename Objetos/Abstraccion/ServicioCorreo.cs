using System;

namespace Objetos.Abstraccion
{
    public class ServicioCorreo : ServicioCorreoAbstracto
    {
  
        private void Conectarse()
        {
            Console.WriteLine("Conectado al servidor");
        }
        private void Desconectarse()
        {
            Console.WriteLine("desconectado del servidor");
        }
        private void Autenticarse()
        {
            Console.WriteLine("Usuario Autenticado");
        }

        public override void EnviarCorreo(string mensaje)
        {
            Conectarse();
            Autenticarse();
            //Enviar correo
            Console.WriteLine("Enviando el mensaje: " + mensaje);
            Desconectarse();
        }
    }
}
