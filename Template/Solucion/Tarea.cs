using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Solucion
{
    public abstract class Tarea
    {
        private PistasAuditoria logger;
        protected string nombreProceso;

        public Tarea()
        {
            // Declaramos un objeto que guarde las pistas de auditoria
            this.logger = new PistasAuditoria();
        }

        internal void Ejecutar()
        {
            // Paso 1: Tareas Especificas
            ImplementaEjecutar();
            // Paso 2: Guardar el Log
            logger.CrearLog(nombreProceso, "Pepito Perez");
        }

        protected abstract void ImplementaEjecutar();
    }
}
