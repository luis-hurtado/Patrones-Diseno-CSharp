namespace Flyweight.Antes
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var servicio = new ServicioPuntos();
            var puntos = servicio.ObtenerPuntos();
            foreach (Punto punto in puntos)
            {
                punto.Dibujar();
            }
        }
    }
}
