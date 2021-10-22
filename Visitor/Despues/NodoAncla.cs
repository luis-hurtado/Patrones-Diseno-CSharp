using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public class NodoAncla : INodoHtml
    {
        public void Ejecutar(IOperacion operacion)
        {
            operacion.Ejecutar(this);
        }

        
    }
}
