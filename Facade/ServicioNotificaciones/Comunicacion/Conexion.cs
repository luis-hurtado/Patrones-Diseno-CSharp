using System;

namespace Facade.ServicioNotificaciones.Comunicacion
{
    public class Conexion
    {
        private readonly string direccionIP;

        public Conexion(string direccionIP)
        {
            this.direccionIP = direccionIP;
            Console.WriteLine("Se conecto al servidor: " + direccionIP);
        }

        internal void Desconectar()
        {
            Console.WriteLine("Se desconecto del servidor: " + direccionIP);
            Console.WriteLine("------------------------------------------------------" );
            Console.WriteLine();
        }
    }
}