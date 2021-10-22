using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Antes
{
    public class NodoCabecera : INodoHtml
    {
        public void Resaltar()
        {
            Console.WriteLine("Resaltando el nodo cabecera");
        }
    }
}
