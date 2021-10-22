﻿namespace Mediator.Observer
{
    public class Button : ManejadorEventos
    {
        private bool habilitado;

        public bool Habilitado
        {
            get => habilitado;
            set
            {
                habilitado = value;
                ProcesarEvento();
            }
        }
    }
}
