using System;

namespace State.Demo
{
    public class HerramientaBorrador : IHerramienta
    {
        void IHerramienta.MouseDown()
        {
            Console.WriteLine("Mostrar icono de borrador");
        }

        void IHerramienta.MouseUp()
        {
            Console.WriteLine("Eliminar/Borrar el area seleccionada");
        }
    }
}
