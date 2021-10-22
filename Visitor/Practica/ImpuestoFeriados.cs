using System;

namespace Visitor.Practica
{
    public class ImpuestoFeriados : IVisitor
    {        
        public double Visitar(IElemento elemento)
        {
            switch (elemento)
            {
                case Licor l:
                    Console.WriteLine("Item de Licor: Precio con impuestos");
                    return l.Precio * 1.30;
                case Tabaco t:
                    Console.WriteLine("Item de tabaco: Precio con impuestos");
                    return t.Precio * 1.20;
                case PrimeraNecesidad n:
                    Console.WriteLine("Item de primera necesidad: Precio con impuestos");
                    return n.Precio * 1.00;
                default:
                    return 0;
            }

        }        
    }
}
