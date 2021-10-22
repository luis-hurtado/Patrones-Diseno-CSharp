using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Despues
{
    public class WebServer
    {
        private Manejador manejador;

        public WebServer(Manejador manejador)
        {
            this.manejador = manejador;
        }

        public void ManejarRequest(HttpRequest request)
        {
            manejador.Manejar(request);
        }
    }
}
