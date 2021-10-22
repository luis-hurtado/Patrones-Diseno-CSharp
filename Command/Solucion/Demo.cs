using Command.Solucion.Aplicacion;
using Command.Solucion.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Solucion
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var servicio = new CustomerService();
            // Al hacer Click en el boton queremos que se ejecute
            // el metodo de añadir al cliente a la BD
            var comandoAgregar = new ComandoAgregarCliente(servicio);
            var btnAgregar = new Boton(comandoAgregar);
            btnAgregar.Click();

            // Al hacer Click en el boton queremos que se ejecute
            // el metodo de añadir al cliente a la BD
            var comandoEliminar = new ComandoEliminarCliente(servicio);
            var btnEliminar = new Boton(comandoEliminar);
            btnEliminar.Click();

        }
    }
}
