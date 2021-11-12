using System;

namespace Facade.ServicioNotificaciones.Autenticacion
{
    public class AutenticacionPorToken
    {
        private string idAplicacion;
        private string llave;

        private static string TOKEN = "ASDH!123QADAS";

        public AutenticacionPorToken(string idAplicacion, string llave)
        {
            Console.WriteLine("Token generado para " + idAplicacion + " con la llave " + llave);
            this.idAplicacion = idAplicacion;
            this.llave = llave;
        }

        public string Token
        {
            get
            {
                return TOKEN;
            }
        }
    }
}