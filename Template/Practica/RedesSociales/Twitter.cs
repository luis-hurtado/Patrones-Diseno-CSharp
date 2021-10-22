using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Practica.RedesSociales
{
    internal class Twitter : RedSocial
    {

        public Twitter(string usuario, string password)
        {
            this.nombreUsuario = usuario;
            this.password = password;
        }

        protected override bool Conectarse(string usuario, string password)
        {
            Console.WriteLine("\nComprobando los parámetros del usuario");
            Console.WriteLine("Nombre: " + this.nombreUsuario);
            Console.WriteLine("Password: ");
            for (int i = 0; i < this.password.Length; i++)
            {
                Console.Write("*");
            }
            SimulateNetworkLatency();
            Console.WriteLine("\n\nConexion exitosa en  Twitter");
            return true;
        }

        protected override void Desconectarse()
        {
            Console.WriteLine("Usuario: '" + nombreUsuario + "' fue desconectado de Twitter");
        }

        protected override bool PublicarMensaje(string mensaje)
        {
            bool messagePosted = true;
            if (messagePosted)
            {
                Console.WriteLine("Mensaje: '" + mensaje + "' fue publicado en Twitter");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
