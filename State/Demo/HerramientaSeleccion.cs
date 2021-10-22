using System;

namespace State.Demo
{
    public class HerramientaSeleccion : IHerramienta
    {
        public void MouseDown()
        {
            Console.WriteLine("Se muestra el icono de seleccion");
        }

        public void MouseUp()
        {
            // Aqui va toda la logica necesaria para dibujar el rectangulo
            Console.WriteLine("Se dibuja un rectangulo segmentado....");
        }
    }
}
