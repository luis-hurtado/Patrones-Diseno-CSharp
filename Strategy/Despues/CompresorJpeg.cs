using System;

namespace Strategy.Despues
{
    public class CompresorJpeg : ICompresor
    {
        public void Comprimir()
        {
            Console.WriteLine("Se comprimio la imagen utilizando JPEG");
        }
    }
}
