using System;

namespace Observer.DemoPush
{
    internal class HojaTotales : IObservador
    {
        public void Actualizar(int valor)
        {
            Console.WriteLine("Actualizar el monto total de las ventas con el valor: " + valor);
        }
    }
}
