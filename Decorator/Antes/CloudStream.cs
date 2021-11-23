using System;

namespace Decorator.Antes
{
    internal class CloudStream
    {
        public virtual void Escribir(string data)
        {
            Console.WriteLine("Almacenando en la nube:" + data);
        }
    }
}
