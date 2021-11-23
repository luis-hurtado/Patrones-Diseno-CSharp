using System;

namespace Decorator.Despues
{
    internal class CloudStream : IStream
    {
        public virtual void Escribir(string data)
        {
            Console.WriteLine("Almacenando en la nube:" + data);
        }
    }
}
