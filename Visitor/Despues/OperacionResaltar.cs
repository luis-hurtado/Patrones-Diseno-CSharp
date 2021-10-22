using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public class OperacionResaltar : IOperacion
    {
        public void Ejecutar(NodoAncla ancla)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ancla - Resaltando el nodo.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Ejecutar(NodoCabecera cabera)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cabecera - Resaltando el nodo.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
