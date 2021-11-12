namespace Facade.ServicioNotificaciones.Autenticacion
{
    public class AutenticacionPorToken
    {
        private string idAplicacion;
        private string llave;

        public AutenticacionPorToken(string idAplicacion, string llave)
        {
            System.Console.WriteLine("Creando el token");
            this.idAplicacion = idAplicacion;
            this.llave = llave;
        }
    }
}