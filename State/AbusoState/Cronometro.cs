using System;

namespace State.AbusoState
{
    public class Cronometro
    {

        private IEstado estadoActual;

        public Cronometro()
        {
            estadoActual = new EstadoDetenido(this);
        }

        public IEstado EstadoActual { get => estadoActual; set => estadoActual = value; }

        public void Click()
        {
            estadoActual.Click();
        }

       
    }
}
