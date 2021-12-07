using System;

namespace Prototype.Demo.Despues
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

        public string Nombre { get; set; }

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public void Dibujar()
        {
            Console.ForegroundColor = color;
            string valor = (id == 0) ? "Original" : "Clon:" + id;
            Console.WriteLine($"Dibujando el circulo {valor} con radio:{radio}");
            Console.ResetColor();
        }

        public IComponente Clonar()
        {
            Circulo destino = new Circulo
            {
                Color = color,
                Radio = radio
            };
            return destino;
        }
    }
}
