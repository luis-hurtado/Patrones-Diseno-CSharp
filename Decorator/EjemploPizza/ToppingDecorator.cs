using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.EjemploPizza
{
    // El topping tiene una relacion del tipo "Tiene una" con Pizza.
    // Esta es una relacion de Agregacion
    internal abstract class ToppingDecorator : IPizza
    {
        protected IPizza pizza;

        // Asignamos la instancia al atributo pizza.
        // Gracias a esto, todos los decoradores pueden personalizar
        // dinámicamente la instancia de la Pizza base
        public ToppingDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual String ObtenerDescripcion()
        {
            return pizza.ObtenerDescripcion();
        }

        public virtual double ObtenerCosto()
        {
            return pizza.ObtenerCosto();
        }
    }
}
