using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Practica
{
    public class Licor : IElemento
    {
        private readonly double precio;

        public Licor(double precio)
        {
            System.Console.WriteLine("Producto del tipo licor añadido, Precio:" + precio);
            this.precio = precio;
        }

        public double Precio => precio;


        public double Aplicar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
