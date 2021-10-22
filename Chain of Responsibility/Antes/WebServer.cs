using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Demo
{
    public class WebServer
    {
        Autenticacion autenticacion;
        Logger logger;
        Compresor compresor;

        public WebServer(Autenticacion autenticacion, Logger logger, Compresor compresor)
        {
            this.autenticacion = autenticacion;
            this.logger = logger;
            this.compresor = compresor;
        }

        public void ManejarRequest(HttpRequest request)
        {
            // Autenticar el request
            autenticacion.Autenticar(request);
            // Hacer el registro del Log para el request
            logger.RegistrarLog(request);
            // Comprimir el mensaje del request
            compresor.Comprimir(request);
        }
    }
}
