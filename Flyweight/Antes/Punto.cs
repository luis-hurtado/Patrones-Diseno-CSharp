using System;

namespace Flyweight.Antes
{
    internal class Punto
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        private TipoPunto tipo; // 4 bytes
        private sbyte[] icono; // 20 kbytes * 1000 => 20Mb
        

        public Punto(int x, int y, TipoPunto tipo, sbyte[] icono)
        {
            this.x = x;
            this.y = y;
            this.tipo = tipo;
            this.icono = icono;
        }

        public void Dibujar()
        {
            Console.WriteLine($"{tipo} en coordenadas ({x},{y})");
        }
    }

}
