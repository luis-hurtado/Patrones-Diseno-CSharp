using Factory_Method.Demo.Despues.Cobra;

using System;
using System.Collections.Generic;

namespace Factory_Method.Demo.Despues
{
    internal class ControladorProductos : ControladorCobra
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
