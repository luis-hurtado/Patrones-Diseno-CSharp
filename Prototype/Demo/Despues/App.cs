using System;

namespace Prototype.Demo.Despues
{
    internal class App
    {
        public static void Ejecutar() {
            Circulo origen = new Circulo
            {
                Radio = 6,
                Color = ConsoleColor.Blue
            };
            origen.Dibujar();

            MenuContextual menu = new MenuContextual();
            var clon = menu.Duplicar(origen);
            clon.Dibujar();

            origen.Radio = 3;
            origen.Color = ConsoleColor.Green;
            origen.Dibujar();

            clon.Dibujar();

            var clon2 = menu.Duplicar(origen);
            clon2.Dibujar();

            var clon3 = menu.Duplicar(clon);
            clon3.Dibujar();


        }
    }
}
