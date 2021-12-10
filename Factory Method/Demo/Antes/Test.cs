using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Demo.Antes
{
    internal class Test
    {
        public static void Ejecutar()
        {
            var controlador = new ControladorProductos();
            controlador.ListarProductos();
        }
    }
}
