using System;

namespace Chain_of_Responsibility.Demo
{
    public class Compresor
    {
        public void Comprimir(HttpRequest request)
        {
            Console.WriteLine("COMPRESOR");
            if (request.Tamanio > 1024)
                Console.WriteLine("Se comprimio el archivo");
        }
    }
}