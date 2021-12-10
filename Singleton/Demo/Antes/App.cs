using System;

namespace Singleton.Demo.Antes
{
    internal class App
    {
        public static void Ejecutar()
        {
            Console.WriteLine("DEMO ANTES");

            ConfigManager manejador = new ConfigManager();
            manejador.Set("Nombre_Aplicacion", "MiAplicacion");
            manejador.Set("Version", 1);
            Console.WriteLine("Utilizamos la nueva configuracion");
            Console.WriteLine($"El valor del setting Nombre_Aplicacion es {manejador.Get("Nombre_Aplicacion")}");

            Console.WriteLine("\n\nTratamos de utilizar la configuracion desde otro punto en la solucion.");
            ConfigManager otroManejador = new ConfigManager();
            Console.WriteLine($"El valor del setting Nombre_Aplicacion es {otroManejador.Get("Nombre_Aplicacion")}");

        }
    }
}
