using Facade.ServicioNotificaciones;
using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;

namespace Facade.Despues
{
    public class Demo2
    {
        public static void EjecutarOtroMetodo()
        {
            FachadaServicioNotificaciones servicio = new FachadaServicioNotificaciones();
            servicio.EnviarMensaje("este es otro modulo de la aplicacion", "Alumnos del Curso");
        }
    }
}
