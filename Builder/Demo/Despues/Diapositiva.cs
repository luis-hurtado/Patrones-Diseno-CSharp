namespace Builder.Demo.Despues
{
    internal class Diapositiva
    {
        private readonly string texto;

        public Diapositiva(string texto)
        {
            this.texto = texto;
        }

        public string Texto => texto;
    }
}
