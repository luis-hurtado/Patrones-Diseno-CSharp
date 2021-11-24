using System;

namespace Decorator.EjemploPizza.Toppings
{
    internal class Chorizo : ToppingDecorator
    {
        public Chorizo(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Agregando Chorizos");
        }

        public override string ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion() + ", chorizos";
        }

        public override double ObtenerCosto()
        {
            Console.WriteLine("Costo del chorizo: " + 15.00);
            return pizza.ObtenerCosto() + 15.00;
        }

    }
}