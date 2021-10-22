namespace Command.Solucion.Framework
{
    public class Boton
    {
        private IComando comando;

        public Boton(IComando comando)
        {
            this.comando = comando;
        }

        public string Label { get; set; }

        public void Click()
        {
            comando.Ejecutar();
        }
    }
}
