using System;

namespace Prototype.Demo.Antes
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

        }
    }
}
