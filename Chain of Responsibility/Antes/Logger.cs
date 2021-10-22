using System;

namespace Chain_of_Responsibility.Demo
{
    public class Logger
    {
        public void RegistrarLog(HttpRequest request)
        {
            Console.WriteLine("REGISTRO LOGS");
            if (request.Tipo == "Clasificado")
                Console.WriteLine("Se registro el log del mensaje");
        }
    }
}