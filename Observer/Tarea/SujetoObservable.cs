using System;
using System.Collections.Generic;

namespace Observer.Tarea
{
    internal class SujetoObservable : IObservable<int>
    {
        private List<IObserver<int>> observadores = new List<IObserver<int>>();

        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!observadores.Contains(observer))
                observadores.Add(observer);
            return new Unsubscriber(observadores, observer);
        }

        public void ActualizarObservadores(int data)
        {
            foreach (var observer in observadores)
            {
                if (data <= 0)
                    observer.OnError(new Exception("la accion no puede valer menos de 0"));
                else
                    observer.OnNext(data);
            }
        }

        public void CierreAcciones()
        {
            foreach (var observer in observadores.ToArray())
                if (observadores.Contains(observer))
                    observer.OnCompleted();

            observadores.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<int>> _observers;
            private IObserver<int> _observer;

            public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
