using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Decorator.EjemploPizza.Toppings;

namespace Decorator.EjemploPizza
{
    internal class Ejercicio
    {
        public static void Ejecutar()
        {
            // The PizzaBase object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor
            Console.WriteLine();
            Console.WriteLine("Preparando una pizza basica");
            IPizza pizzaBase = new Mozzarella(new MasaConSalsaDeTomate(new PizzaBase()));
            Console.WriteLine("Ingredientes: " + pizzaBase.ObtenerDescripcion());
            Console.WriteLine("Precio: " + pizzaBase.ObtenerCosto());

            Console.WriteLine();
            Console.WriteLine("Preparando la pizza Hawaiana a partir de la Pizza base");
            IPizza pizzaHawaiana = new Hawayana(pizzaBase);
            Console.WriteLine("Ingredientes: " + pizzaHawaiana.ObtenerDescripcion());
            Console.WriteLine("Precio: " + pizzaHawaiana.ObtenerCosto());

            Console.WriteLine();
            Console.WriteLine("Preparando la pizza de Chorizo a partir de la Pizza base");
            IPizza pizzaChorizo = new Chorizo(pizzaBase);
            Console.WriteLine("Ingredientes: " + pizzaChorizo.ObtenerDescripcion());
            Console.WriteLine("Precio: " + pizzaChorizo.ObtenerCosto());

            Console.WriteLine();
            Console.WriteLine("Preparando la pizza Boliviana a partir de la Pizza base");
            IPizza pizzaBoliviana = new Boliviana(pizzaBase);
            Console.WriteLine("Ingredientes: " + pizzaBoliviana.ObtenerDescripcion());
            Console.WriteLine("Precio: " + pizzaBoliviana.ObtenerCosto());
        }
    }
}
