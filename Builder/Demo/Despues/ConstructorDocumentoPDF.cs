namespace Builder.Demo.Despues
{
    internal class ConstructorDocumentoPDF : IConstructorPresentacion
    {
        private DocumentoPDF documento = new DocumentoPDF();
        public void AgregarDiapositiva(Diapositiva diapositiva)
        {
            documento.AgregarPagina(diapositiva.Texto);
        }
    }
}
