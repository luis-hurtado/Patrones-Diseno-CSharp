using System;

namespace Decorator.EjemploPizza
{
    // Implementamos la interface Pizza solo con los metodos requeridos

    // Todas las demas Pizza se basan en la piza base
    internal class PizzaBase : IPizza
    {
        public String ObtenerDescripcion()
        {
            return "Masa fina";
        }

        public double ObtenerCosto()
        {
            Console.WriteLine("Costo de la Masa: " + 30.00);
            return 30.00;
        }
    }
}