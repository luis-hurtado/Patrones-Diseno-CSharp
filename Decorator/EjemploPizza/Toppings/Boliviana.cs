using System;

namespace Decorator.EjemploPizza.Toppings
{
    internal class Boliviana : ToppingDecorator
    {
        public Boliviana(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Agregando Cebollas Caramelizadas");
            Console.WriteLine("Agregando Locotos");
        }
        
        public override String ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion() + ", cebollas, locotos";
        }

        public override double ObtenerCosto()
        {
            Console.WriteLine("Costo de las verduras: " + 5);
            return pizza.ObtenerCosto() + 5;
        }

    }
}