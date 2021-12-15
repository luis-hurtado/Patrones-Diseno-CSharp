namespace Builder.Demo.Antes
{
    internal class Test
    {
        public static void Ejecutar()
        {
            var presentacion = new Presentacion();
            presentacion.AgregarDiapositiva(new Diapositiva("Caratula: PATRON BUILDER"));
            presentacion.AgregarDiapositiva(new Diapositiva("Proposito"));
            presentacion.AgregarDiapositiva(new Diapositiva("Problema"));
            presentacion.AgregarDiapositiva(new Diapositiva("Solucion"));
            presentacion.AgregarDiapositiva(new Diapositiva("Estructura"));
            presentacion.AgregarDiapositiva(new Diapositiva("Aplicabilidad"));
            presentacion.AgregarDiapositiva(new Diapositiva("Consecuencias"));

            //presentacion.Exportar(FormatoDestino.PDF);
            presentacion.Exportar(FormatoDestino.VIDEO);
        }
    }
}
