using System;
using static State.Tarea.Compra;

namespace State.Tarea.EstadosCompra
{
    internal class Cancelada : EstadoCompra
    {
        public Cancelada(Compra compra) : base(compra)
        {
        }       
        
    }
}
