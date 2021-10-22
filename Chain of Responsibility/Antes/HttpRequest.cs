namespace Chain_of_Responsibility.Demo
{
    public class HttpRequest
    {
        public HttpRequest(string usuario, string password, string tipo, int tamanio)
        {
            Usuario = usuario;
            Password = password;
            Tipo = tipo;
            Tamanio = tamanio;
        }

        public string Usuario { get; internal set; }
        public string Password { get; internal set; }
        public string Tipo { get; internal set; } = "Clasificado";
        public int Tamanio { get; internal set; } = 2048;
    }
}