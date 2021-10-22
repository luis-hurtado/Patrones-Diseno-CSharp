using System;

namespace Visitor.Practica
{
    public class ImpuestoGeneral : IVisitor
    {        
        public double Visitar(IElemento elemento)
        {
            double impuesto;
            switch (elemento)
            {
                case Licor l:
                    Console.WriteLine("Item de Licor: Precio con impuestos");
                    impuesto = l.Precio * 1.22;
                    break;
                case Tabaco t:
                    Console.WriteLine("Item de tabaco: Precio con impuestos");
                    impuesto = t.Precio * 1.18;
                    break;
                case PrimeraNecesidad n:
                    Console.WriteLine("Item de primera necesidad: Precio con impuestos");
                    impuesto = n.Precio * 1.13;
                    break;
                default:
                    impuesto = 0;
                    break;
            }
            return Math.Round(impuesto, 2, MidpointRounding.ToEven);
           
        }        
    }
}
