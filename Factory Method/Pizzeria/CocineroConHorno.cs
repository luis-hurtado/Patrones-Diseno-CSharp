using System;

namespace Factory_Method.Pizzeria
{
    internal class CocineroConHorno : Cocinero
    {
        protected override Pizza CrearPizza()
        {
            return new PizzaAlHorno();
        }

        internal override void Encajonar()
        {
            Console.WriteLine("Echandole aceite de oliva con oregano encima a la pizza");
            base.Encajonar();
        }
    }
}
