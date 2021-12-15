namespace Builder.Demo.Despues
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

            
            presentacion.Exportar(new ConstructorDocumentoPDF());
            System.Console.WriteLine();
            System.Console.WriteLine();
            presentacion.Constructor = new ConstructorVideoMP4();
            presentacion.Exportar();
        }
    }
}
