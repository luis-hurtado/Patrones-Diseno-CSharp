using System;

namespace Flyweight.Despues
{
    internal class Punto
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        private IconosPunto iconosPunto;


        public Punto(int x, int y, IconosPunto iconosPunto)
        {
            this.x = x;
            this.y = y;
            this.iconosPunto = iconosPunto;
        }

        public void Dibujar()
        {
            Console.WriteLine($"{iconosPunto.Tipo} en coordenadas ({x},{y})");
        }
    }

}
