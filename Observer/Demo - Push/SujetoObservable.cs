using System.Collections.Generic;

namespace Observer.DemoPush
{
    internal abstract class SujetoObservable
    {
        List<IObservador> observadores = new List<IObservador>();

        public void AgregarObservador(IObservador nuevoObservador)
        {
            observadores.Add(nuevoObservador);
        }
        public void EliminarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }
        public void ActualizarObservadores(int valor)
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(valor);
            }
        }
    }
}
