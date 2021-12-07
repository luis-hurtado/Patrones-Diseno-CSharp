namespace Prototype.Demo.Antes
{
    internal class MenuContextual
    {
        public IComponente Duplicar(IComponente componente)
        {
            IComponente destino = null;
            if(componente is Circulo origen)
            {
                Circulo clon = new Circulo
                {
                    Color = origen.Color,
                    Radio = origen.Radio
                };
                destino = clon;
            }

            return destino;
        }
    }
}
