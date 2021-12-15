using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Demo.Despues
{
    internal class ConstructorVideoMP4 : IConstructorPresentacion
    {
        private const int Duracion = 3;
        private VideoMP4 video = new VideoMP4();
        public void AgregarDiapositiva(Diapositiva diapositiva)
        {
            video.AgregarFrame(diapositiva.Texto, Duracion);
        }
    }
}
