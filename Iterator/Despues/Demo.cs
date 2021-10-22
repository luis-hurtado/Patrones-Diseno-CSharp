using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Despues
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var historial = new BrowseHistory();
            historial.Push("http://www.google.com/");
            historial.Push("http://www.wikipedia.com/");
            historial.Push("https://www.google.com.bo/maps/");

            var historial2 = new BrowseHistoryArray();
            historial2.Push("http://www.Otro.com/");
            historial2.Push("http://www.otrawikipedia.com/");
            historial2.Push("https://www.google.com.bo/images/");

            // Iteramos nuestro historial para mostrarlo en pantalla
            MostrarHistorial(historial);
            MostrarHistorial(historial2);
        }

        private static void MostrarHistorial(IAgregado historial)
        {
            IIterador coleccion = historial.CrearIterador();
            while (coleccion.TieneSiguiente())
            {
                var url = coleccion.Actual();
                Console.WriteLine(url);
                coleccion.Siguiente();
            }
        }
    }
}
