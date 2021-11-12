namespace Facade.ServicioNotificaciones.Modelos
{
    public class Mensaje
    {
        public Mensaje(string mensaje)
        {
            this.Contenido = mensaje;
        }

        public string Contenido { get; set; }
    }
}