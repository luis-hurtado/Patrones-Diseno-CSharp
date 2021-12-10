using System;

namespace Factory_Method.Pizzeria
{
    internal class CocineroConHornoALaPiedra : Cocinero
    {
        protected override Pizza CrearPizza()
        {
            return new PizzaALAPiedra();
        }

        internal override void Cortar()
        {
            Console.WriteLine("Cortando tajadas cuadradas");
        }

    }
}
