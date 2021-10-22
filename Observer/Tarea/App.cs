namespace Observer.Tarea
{
    public class App
    {
        internal static void Ejecutar()
        {
            // Sujeto observable
            Acciones ventas = new Acciones();

            // Observadores
            VisorAcciones statusBar = new VisorAcciones("StatusBar");
            ventas.Subscribe(statusBar);

            VisorAcciones listView = new VisorAcciones("ListView");
            listView.Subscribirse(ventas);

            // Actualice el estado del sujeto observable
            ventas.Dato = 100;

            // Eliminar alguin observador
            listView.QuitarSubscripcion();

            // Actualizamos nuevamente el estado del sujeto observable
            ventas.Dato = 0;

            ventas.Dato = 20;

            ventas.CierreAcciones();
        }
    }
}
