using System;

namespace Chain_of_Responsibility.Despues
{
    public class Logger : Manejador
    {
        public Logger(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("REGISTRO LOGS");
            if (request.Tipo == "Clasificado")
                Console.WriteLine("Se registro el log del mensaje");

            return false;
        }

    }
}