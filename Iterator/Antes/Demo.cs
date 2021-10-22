using System;

namespace Iterator.Antes
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var historial = new BrowseHistory();
            historial.Push("http://www.google.com/");
            historial.Push("http://www.wikipedia.com/");
            historial.Push("https://www.google.com.bo/maps/");

            // Iteramos nuestro historial para mostrarlo en pantalla
            for (int i = 0; i < historial.Urls.Count; i++)
            {
                var url = historial.Urls[i];
                Console.WriteLine(url);
            }
        }
    }
}
