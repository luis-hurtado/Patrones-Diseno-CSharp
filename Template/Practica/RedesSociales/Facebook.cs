using System;

namespace Template.Practica.RedesSociales
{
    internal class Facebook : RedSocial
    {

        public Facebook(string usuario, string password)
        {
            this.nombreUsuario = usuario;
            this.password = password;
        }

        protected override bool Conectarse(string usuario, string password)
        {
            Console.WriteLine("\nComprobando los parámetros del usuario");
            Console.WriteLine("Usuario: " + this.nombreUsuario);
            Console.WriteLine("Password: ");
            for (int i = 0; i < this.password.Length; i++)
            {
                Console.Write("*");
            }
            SimulateNetworkLatency();
            Console.WriteLine("\n\nConexion exitosa en Facebook");
            return true;
        }

        protected override void Desconectarse()
        {
            Console.WriteLine("Usuario: '" + nombreUsuario + "' fue desconectado de Facebook");
        }

        protected override bool PublicarMensaje(string mensaje)
        {
            bool messagePosted = true;
            if (messagePosted)
            {
                Console.WriteLine("Mensaje: '" + mensaje + "' fue publicado en Facebook");
                return true;
            }
            else
            {
                return false;
            }
        }       

    }
}
