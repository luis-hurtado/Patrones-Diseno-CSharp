using Command.Solucion.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Solucion.Aplicacion
{
    class ComandoAgregarCliente : IComando
    {
        private CustomerService servicio;

        public ComandoAgregarCliente(CustomerService servicio)
        {
            this.servicio = servicio;
        }

        public void Ejecutar()
        {
            servicio.AgregarCliente();
        }
    }
}
