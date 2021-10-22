using System;
using System.Collections.Generic;

namespace Mediator.Observer
{
    public abstract class ManejadorEventos
    {
        private List<Action> eventos = new List<Action>();

        public void AgregarEvento(Action evento)
        {
            eventos.Add(evento);
        }

        protected void ProcesarEvento()
        {
            foreach (var evento in eventos)
            {
                evento();
            }
        }

    }
}
