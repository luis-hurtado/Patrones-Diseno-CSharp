namespace Chain_of_Responsibility.Despues
{
    public class App
    {
        public static void Ejecutar()
        {
            //Compresor compresor = new Compresor(encriptador);
            Logger logger = new Logger(null);
            Encriptador encriptador = new Encriptador(logger);
            Autenticacion autenticacion = new Autenticacion(encriptador);

            // declaramos nuestro servidor
            WebServer servidor = new WebServer(autenticacion);

            servidor.ManejarRequest(new HttpRequest("Admin", "1234", "Clasificado", 2048));
            //servidor.ManejarRequest(new HttpRequest("Admin", "12", "Clasificado",640));

        }
    }
}
