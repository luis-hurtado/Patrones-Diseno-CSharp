namespace Flyweight.Despues
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var servicio = new ServicioPuntos(new FabricaIconosPunto());
            var puntos = servicio.ObtenerPuntos();
            foreach (Punto punto in puntos)
            {
                punto.Dibujar();
            }
        }
    }
}
