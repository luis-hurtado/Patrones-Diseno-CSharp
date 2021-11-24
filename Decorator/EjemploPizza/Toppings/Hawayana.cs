using System;

namespace Decorator.EjemploPizza.Toppings
{
    internal class Hawayana : ToppingDecorator
    {
        public Hawayana(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Agregando Piñas");
            Console.WriteLine("Agregando Cherrys");
        }
        
        public override String ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion() + ", piñas, cherrys";
        }

        public override double ObtenerCosto()
        {
            Console.WriteLine("Costo de las frutas: " + 10.50);
            return pizza.ObtenerCosto() + 10.50;
        }

    }
}