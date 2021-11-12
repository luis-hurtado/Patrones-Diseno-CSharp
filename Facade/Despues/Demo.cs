using Facade.ServicioNotificaciones;
using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;

namespace Facade.Despues
{
    internal class Demo
    {
        public static void Ejecutar() {
            FachadaServicioNotificaciones servicio = new FachadaServicioNotificaciones();
            servicio.EnviarMensaje("Despierta","Migdo");
            servicio.EnviarMensaje("Espero mejore tu conexion", "Armin");
            servicio.EnviarMensaje("Espero mejore tu codigo", "David");
        }
    }
}
