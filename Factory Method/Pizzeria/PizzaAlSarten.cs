using System;
using System.Collections.Generic;

namespace Factory_Method.Pizzeria
{
    internal class PizzaAlSarten : Pizza
    {
        public void Cocinar()
        {            
            Console.WriteLine("Cocinando en el sarten todos los ingredientes");
        }
    }



}
