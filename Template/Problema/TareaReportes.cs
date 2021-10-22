using System;

namespace Template.Problema
{
    internal class TareaReportes
    {
        private PistasAuditoria logger;

        public TareaReportes(PistasAuditoria logger)
        {
            this.logger = logger;
        }

        internal void Ejecutar()
        {
            Console.WriteLine("Se realizó la generacion del reporte ...");
            logger.CrearLog("GeneracionReporte", "Anita Bananas");
        }
    }
}