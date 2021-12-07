using System;

namespace Prototype.Demo.Antes
{
    internal class Circulo : IComponente
    {
        private int radio;
        private ConsoleColor color;
        private int id;
        private static int semilla = 0;

        public Circulo()
        {
            id = semilla++;
        }

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }


        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public void Dibujar()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Dibujando el circulo {id} con radio:{radio}");
            Console.ResetColor();
        }
    }
}
