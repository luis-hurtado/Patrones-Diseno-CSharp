using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Despues
{
    public class Demo
    {
        public static void Ejecutar()
        {
            // documento -> Html
            var documento = new DocumentoHtml();
            // Agregar nodos html
            documento.AgregarNodo(new NodoCabecera());
            documento.AgregarNodo(new NodoAncla());
            // Aplicamos la funcionalidad de resaltado
            documento.Ejecutar(new OperacionResaltar());
            documento.Ejecutar(new OperacionTextoPlano());
        }
    }
}
