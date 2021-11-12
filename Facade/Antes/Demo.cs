using Facade.ServicioNotificaciones;
using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;

namespace Facade.Antes
{
    internal class Demo
    {
        public static void Ejecutar() {
            var servicio = new ServidorNotificaciones();
            Conexion conexion = servicio.Conectar("10.1.1.125");
            AutenticacionPorToken token = servicio.Autenticarse("MiAplicacion", "Vmpbugn");
            Mensaje mensaje = new Mensaje("Saludos Alumnos no se duerman");
            servicio.EnviarMensaje(token,mensaje,"Alumnos del curso de Patrones");
            conexion.Desconectar();
        }
    }
}
