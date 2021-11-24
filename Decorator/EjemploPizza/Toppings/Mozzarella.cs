using System;

namespace Decorator.EjemploPizza.Toppings
{
    internal class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Agregando el queso mozzarella");
        }
                
        public override String ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion() + ", queso mozzarella";
        }

        public override double ObtenerCosto()
        {
            Console.WriteLine("Costo del queso: " + 5.50);
            return pizza.ObtenerCosto() + 5.50;
        }

    }
}
