using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public class OperacionTextoPlano : IOperacion
    {
        public void Ejecutar(NodoAncla ancla)
        {
            Console.WriteLine("Ancla - Se exporto a texto plano");
        }

        public void Ejecutar(NodoCabecera cabera)
        {
            Console.WriteLine("Cabecera - Se exporto a texto plano");
        }
    }
}
