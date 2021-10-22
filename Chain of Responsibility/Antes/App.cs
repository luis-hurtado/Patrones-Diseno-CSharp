using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Demo
{
    public class App
    {
        public static void Ejecutar()
        {
            Autenticacion autenticacion = new Autenticacion();
            Logger logger = new Logger();
            Compresor compresor = new Compresor();

            // declaramos nuestro servidor
            WebServer servidor = new WebServer(autenticacion,logger,compresor);

            servidor.ManejarRequest(new HttpRequest("Admin", "1234", "Normal", 2048));
            servidor.ManejarRequest(new HttpRequest("Admin", "12", "Clasificado",640));

        }
    }
}
