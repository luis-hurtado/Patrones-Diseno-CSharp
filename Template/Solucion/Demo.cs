namespace Template.Solucion
{
    public class Demo
    {
        internal static void Ejecutar()
        {
            // Transferencia de Dinero
            Tarea transferencia = new TareaTransferencias();
            transferencia.Ejecutar();

            //Generar un Reporte
            Tarea reportes = new TareaReportes();
            reportes.Ejecutar();

        }
    }
}
