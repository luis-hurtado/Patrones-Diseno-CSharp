using System;

namespace Observer.Demo
{
    internal class Grafico : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Dibujar el grafico de acuerdo al valor seleccionado");
        }
    }
}
