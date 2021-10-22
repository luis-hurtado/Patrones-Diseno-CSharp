using System;
namespace State.Tarea.EstadosCompra
{
    internal class Verificada : EstadoCompra
    {
        public Verificada(Compra compra) : base(compra)
        {
        }

       
        public override void Enviar()
        {
            Console.WriteLine("La orden ya fue enviada a su destino"); 
            Compra.EstadoActual = Compra.enviada;
        }
       
    }
}
