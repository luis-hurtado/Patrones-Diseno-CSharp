using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Demo.Antes
{
    internal class ControladorProductos : Controlador
    {
        public void ListarProductos()
        {
            // Conectarnos a la base de datos
            // var productos = DB.ObtenerProductos();
            IDictionary<string, Object> contexto = new Dictionary<string, Object>();
            // for producto in productos
            // contexto.put(producto)
            Renderizar("productos.html", contexto);
        }
    }
}
