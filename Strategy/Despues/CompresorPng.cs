using System;

namespace Strategy.Despues
{
    public class CompresorPng : ICompresor
    {
        public void Comprimir()
        {
            Console.WriteLine("Se comprimio la imagen utilizando PNG"); 
        }
    }
}
