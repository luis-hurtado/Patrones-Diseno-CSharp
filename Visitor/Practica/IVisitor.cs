using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Practica
{
    public interface IVisitor
    {
        double Visitar(IElemento elemento);
    }
}
