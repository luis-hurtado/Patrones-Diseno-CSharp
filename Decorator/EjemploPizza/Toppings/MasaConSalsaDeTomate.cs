using System;

namespace Decorator.EjemploPizza.Toppings
{
    internal class MasaConSalsaDeTomate : ToppingDecorator
    {
        public MasaConSalsaDeTomate(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Agregando la masa");
            Console.WriteLine("Agregando la salsa de tomate");
        }

        public override String ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion() + ", salsa de tomate";
        }

        public override double ObtenerCosto()
        {
            Console.WriteLine("Costo de la salsa: " + 3.50);
            return pizza.ObtenerCosto() + 3.50;
        }

    }
}