using System;

namespace Factory_Method.Pizzeria
{
    internal class PizzaAlHorno : Pizza
    {
        public void Cocinar()
        {
            Console.WriteLine("Cocinando en el horno todos los ingredientes");
        }        
    }
}
