using System;

namespace Observer.DemoPush
{
    internal class Grafico : IObservador
    {
        public void Actualizar(int valor)
        {
            Console.WriteLine("Dibujar el grafico de acuerdo al valor seleccionado:" + valor);
        }
    }
}
