namespace Prototype.Demo.Despues
{
    internal class MenuContextual
    {
        public IComponente Duplicar(IComponente componente)
        {
            IComponente destino = componente.Clonar();
            return destino;
        }
    }
}
