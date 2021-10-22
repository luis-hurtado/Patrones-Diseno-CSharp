using System;

namespace Chain_of_Responsibility.Despues
{
    public class Compresor : Manejador
    {
        public Compresor(Manejador siguiente) : base(siguiente)
        {
        }


        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("COMPRESOR");
            if (request.Tamanio > 1024)
                Console.WriteLine("Se comprimio el archivo");
            return false;
        }
    }
}