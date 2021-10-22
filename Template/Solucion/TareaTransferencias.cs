using System;

namespace Template.Solucion
{
    internal class TareaTransferencias : Tarea
    {
        public TareaTransferencias()
        {
            this.nombreProceso = "Transferencias";
        }
        protected override void ImplementaEjecutar()
        {
            Console.WriteLine("Se realizo la transferencia de dinero...");
        }

    }
}