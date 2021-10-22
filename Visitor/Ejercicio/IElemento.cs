namespace Visitor.Ejercicio
{
    /// <summary>
    /// La clase abstracta o interface 'Element'
    /// </summary>
    public interface IElemento
    {
        void Aplicar(IVisitor visitor);
    }
}
