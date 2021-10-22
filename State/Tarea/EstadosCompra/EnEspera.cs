using System;

namespace State.Tarea.EstadosCompra
{
    internal class EnEspera : EstadoCompra
    {
        public EnEspera(Compra compra) : base(compra)
        {
        }

        public override void Cancelar()
        {
            Console.WriteLine("La orden ha sido cancelada");
            Compra.EstadoActual = Compra.cancelada;
        }
       

        public override void Verificar()
        {
            Console.WriteLine("La orden ha sido verificada");
            Compra.EstadoActual = Compra.verificada;
        }
    }
}
