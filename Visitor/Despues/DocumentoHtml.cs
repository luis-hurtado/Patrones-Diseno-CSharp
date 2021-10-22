using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public class DocumentoHtml
    {
        // Lista de Nodos
        List<INodoHtml> nodos = new List<INodoHtml>();

        public void AgregarNodo(INodoHtml nodo)
        {
            nodos.Add(nodo);
        }

        // Resaltado de los nodos
        public void Ejecutar(IOperacion operacion)
        {
            foreach (var nodo in nodos)
            {
                nodo.Ejecutar(operacion);
            }
        }
    }
}
