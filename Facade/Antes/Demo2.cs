using Facade.ServicioNotificaciones;
using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;

namespace Facade.Antes
{
    public class Demo2
    {
        public static void EjecutarOtroMetodo()
        {
            var servicio = new ServidorNotificaciones();
            Conexion conexion = servicio.Conectar("10.1.1.127");
            AutenticacionPorToken token = servicio.Autenticarse("MiAplicacion2", "Vmpbugn");
            Mensaje mensaje = new Mensaje("Saludos Alumnos no se duerman desde otro lado");
            servicio.EnviarMensaje(token, mensaje, "Alumnos del curso de Patrones");
            conexion.Desconectar();
        }
    }
}
