using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory_Method.Pizzeria
{
    internal abstract class Cocinero
    {
        public Pizza Preparar(string nombrePizza, IList<string> ingredientes)
        {
            Console.WriteLine($"---------------- {nombrePizza} ----------------");
            var pizza = CrearPizza();
            UsarIngredientes(ingredientes);
            pizza.Cocinar();
            Cortar();
            Encajonar();
            return pizza;
        }

        protected abstract Pizza CrearPizza();

        internal virtual void Cortar()
        {
            Console.WriteLine("Cortando la pizza");
        }

        internal virtual void Encajonar()
        {
            Console.WriteLine("Poniendo la pizza en el cajon");
        }

        protected virtual void UsarIngredientes(IList<String> ingredientes)
        {
            IList<String> ingredientesBase = new List<string>() { "Masa", "Salsa de tomate", "Queso muzarella" };
            Console.WriteLine($"Agregando ingredientes a la pizza: {string.Join(",", ingredientesBase.Union(ingredientes))}");
        }


    }



}
