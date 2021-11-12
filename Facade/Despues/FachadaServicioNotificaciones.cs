using Facade.ServicioNotificaciones;
using Facade.ServicioNotificaciones.Autenticacion;
using Facade.ServicioNotificaciones.Comunicacion;
using Facade.ServicioNotificaciones.Modelos;

namespace Facade.Despues
{
    internal class FachadaServicioNotificaciones
    {
        public void EnviarMensaje(string mensaje, string destinatarios)
        {
            var servicio = new ServidorNotificaciones();
            Conexion conexion = servicio.Conectar("10.1.1.125");
            AutenticacionPorToken token = servicio.Autenticarse("MiAplicacion", "Vmpbugn");
            Mensaje mensajeAEnviar = new Mensaje(mensaje);
            servicio.EnviarMensaje(token, mensajeAEnviar, destinatarios);
            conexion.Desconectar();
        }
    }
}
