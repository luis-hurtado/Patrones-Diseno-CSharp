using System;

namespace Template.Solucion
{
    internal class TareaReportes : Tarea
    {
        public TareaReportes()
        {
            this.nombreProceso = "Reportes";
        }

        protected override void ImplementaEjecutar()
        {
            Console.WriteLine("Se realizó la generacion del reporte ...");
        }
    }
}