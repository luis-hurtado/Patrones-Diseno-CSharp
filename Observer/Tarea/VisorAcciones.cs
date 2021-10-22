using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Tarea
{
    class VisorAcciones : IObserver<int>
    {
        private IDisposable subscriptor;
        private string nombreControl;
        private int valorAccion;

        public string Nombre
        { get { return this.nombreControl; } }

        public VisorAcciones(string nombre)
        {
            this.nombreControl = nombre;
        }

        public void Subscribirse(IObservable<int> subscriptor)
        {
            this.subscriptor = subscriptor.Subscribe(this);
        }

        public void QuitarSubscripcion()
        {
            subscriptor.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine(this.Nombre + ": Se termino de procesar la informacion.");
            this.QuitarSubscripcion();
        }


        public void OnError(Exception error)
        {
            Console.WriteLine(this.Nombre + ": " + error.Message); ;
        }

        public void OnNext(int value)
        {
            valorAccion = value;
            Console.WriteLine(this.Nombre + ": El valor de la accion es " + valorAccion); ;
        }
    }
}
