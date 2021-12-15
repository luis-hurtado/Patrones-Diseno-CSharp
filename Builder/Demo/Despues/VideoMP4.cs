using System;

namespace Builder.Demo.Despues
{
    internal class VideoMP4
    {
        internal void AgregarFrame(string texto, int duracion)
        {
            Console.WriteLine("Agregando un frame al video");
            Console.WriteLine("TEXTO: " + texto + ", DURACION: " + duracion);
        }
    }
}