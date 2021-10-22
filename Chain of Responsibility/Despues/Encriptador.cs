using System;

namespace Chain_of_Responsibility.Despues
{
    public class Encriptador : Manejador
    {
        public Encriptador(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("Se encripto el archivo");
            return false;
        }
    }
}
