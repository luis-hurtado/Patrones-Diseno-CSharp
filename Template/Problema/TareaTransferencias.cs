using System;

namespace Template.Problema
{
    internal class TareaTransferencias
    {
        private PistasAuditoria logger;

        public TareaTransferencias(PistasAuditoria logger)
        {
            this.logger = logger;
        }

        internal void Ejecutar()
        {
            Console.WriteLine("Se realizo la transferencia de dinero...");
            logger.CrearLog("Transferencia de Dinero","Pepito Perez");
        }
    }
}