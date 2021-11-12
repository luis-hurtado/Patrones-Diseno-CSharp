using System;

namespace Facade.ServicioNotificaciones.Comunicacion
{
    public class Conexion
    {
        private string direccionIP;

        public Conexion(string direccionIP)
        {
            Console.WriteLine("Creando Conexion al servidor " + direccionIP);
            this.direccionIP = direccionIP;
        }

        internal void Desconectar()
        {
            Console.WriteLine("Desconectandose del servidor");
        }
    }
}