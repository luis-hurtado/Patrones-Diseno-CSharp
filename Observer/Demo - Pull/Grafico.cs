using System;

namespace Observer.DemoPull
{
    internal class Grafico : IObservador
    {
        DatoOrigen origen;

        public Grafico(DatoOrigen origen)
        {
            this.origen = origen;
        }
        public void Actualizar()
        {
            Console.WriteLine("Dibujar el grafico de acuerdo al valor seleccionado:" + origen.Dato);
        }
    }
}
