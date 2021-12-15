using System.Collections.Generic;

namespace Builder.Demo.Antes
{
    internal class Presentacion
    {
        private IList<Diapositiva> diapositivas = new List<Diapositiva>();
        public void AgregarDiapositiva(Diapositiva diapositiva)
        {
            diapositivas.Add(diapositiva);
        }

        public void Exportar(FormatoDestino formato)
        {
            if (formato == FormatoDestino.PDF)
            {
                var pdf = new DocumentoPDF();
                foreach (var diapositiva in diapositivas)
                {
                    pdf.AgregarPagina(diapositiva.Texto);
                }
            }
            else if (formato == FormatoDestino.VIDEO)
            {
                var video = new VideoMP4();
                foreach (var diapositiva in diapositivas)
                {
                    video.AgregarFrame(texto: diapositiva.Texto, duracion: 3);
                }
            }
        }
    }
}
