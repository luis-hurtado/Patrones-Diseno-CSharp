using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Antes
{
    public class NodoAncla : INodoHtml
    {
        public void Resaltar()
        {
            Console.WriteLine("Resaltando el nodo Ancla."); ;
        }
    }
}
