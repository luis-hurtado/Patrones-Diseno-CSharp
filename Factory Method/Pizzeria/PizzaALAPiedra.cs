using System;

namespace Factory_Method.Pizzeria
{
    internal class PizzaALAPiedra : Pizza
    {
        public void Cocinar()
        {
            Console.WriteLine("Cocinando en el horno de piedra todos los ingredientes");
        }
    }



}
