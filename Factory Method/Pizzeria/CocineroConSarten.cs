namespace Factory_Method.Pizzeria
{
    internal class CocineroConSarten : Cocinero
    {
        protected override Pizza CrearPizza()
        {
            return new PizzaAlSarten();
        }
    }



}
