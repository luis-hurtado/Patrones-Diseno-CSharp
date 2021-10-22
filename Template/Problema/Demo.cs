namespace Template.Problema
{
    public class Demo
    {
        internal static void Ejecutar()
        {
            // Declaramos un objeto que guarde las pistas de auditoria
            PistasAuditoria logger = new PistasAuditoria();

            // Transferencia de Dinero
            TareaTransferencias transferencia = new TareaTransferencias(logger);
            transferencia.Ejecutar();

            //Generar un Reporte
            TareaReportes reportes = new TareaReportes(logger);
            reportes.Ejecutar();

        }
    }
}
