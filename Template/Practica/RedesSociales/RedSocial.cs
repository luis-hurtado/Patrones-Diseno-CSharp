using System;
using System.Threading;

namespace Template.Practica.RedesSociales
{
    internal abstract class RedSocial
    {
        protected string nombreUsuario;
        protected string password;

        public RedSocial(){}

        public bool Post(String mensaje)
        {
            // Autenticarse antes de publicar.
            // Cada red utiliza un método de autentificación diferente.
            if (Conectarse(this.nombreUsuario, this.password))
            {
                // Envía los datos de la publicación.
                bool result = PublicarMensaje(mensaje);
                Desconectarse();
                return result;
            }
            return false;
        }

        protected abstract bool Conectarse(String usuario, String password);
        protected abstract bool PublicarMensaje(string mensaje);
        protected abstract void Desconectarse();


        protected void SimulateNetworkLatency()
        {
            try
            {
                int i = 0;
                Console.WriteLine();
                while (i < 10)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
