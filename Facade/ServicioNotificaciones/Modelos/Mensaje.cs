namespace Facade.ServicioNotificaciones.Modelos
{
    public class Mensaje
    {
        public Mensaje(string mensaje, string tipo)
        {
            System.Console.WriteLine("El mensaje es de tipo");
            this.Contenido = mensaje;
        }

        public string Contenido { get; set; }
    }
}