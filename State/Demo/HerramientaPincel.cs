using System;

namespace State.Demo
{
    public class HerramientaPincel : IHerramienta
    {
        public void MouseDown()
        {
            Console.WriteLine("Se muestra el icono de pincel");
        }

        public void MouseUp()
        {
            Console.WriteLine("Se dibuja un linea de trazo libre coloreada ....");
        }
    }
}
