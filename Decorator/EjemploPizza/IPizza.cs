namespace Decorator.EjemploPizza
{
    // Blueprint para clases que seran decorators
    internal interface IPizza
    {
        string ObtenerDescripcion();
        double ObtenerCosto();
    }
}