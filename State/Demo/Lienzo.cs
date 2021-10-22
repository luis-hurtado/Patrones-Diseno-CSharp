namespace State.Demo
{
    public class Lienzo
    {
        private IHerramienta tipoHerramientaActual;

        public IHerramienta TipoHerramientaActual { set => tipoHerramientaActual = value; }

        public void MouseDown()
        {
            tipoHerramientaActual.MouseDown();

        }
        public void MouseUp()
        {
            tipoHerramientaActual.MouseUp();
        }

    }
}
