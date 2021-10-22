using Command.Solucion.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Solucion.Aplicacion
{
    class ComandoEliminarCliente : IComando
    {
        private CustomerService servicio;

        public ComandoEliminarCliente(CustomerService servicio)
        {
            this.servicio = servicio;
        }

        public void Ejecutar()
        {
            servicio.EliminarCliente();
        }
    }
}
