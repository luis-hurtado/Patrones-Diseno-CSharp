using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public interface IOperacion
    {
        void Ejecutar(NodoAncla ancla);
        void Ejecutar(NodoCabecera cabera);
    }
}
