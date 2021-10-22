using System;
using static State.Tarea.Compra;

namespace State.Tarea.EstadosCompra
{
    internal class Creada : EstadoCompra
    {
        public Creada(Compra compra) : base(compra)
        {
        }

        public override void Comprar(decimal precio, FormasPago formaPago, FormasEnvio formaEnvio)
        {

            Compra.Precio=precio;
            Compra.FormaPago=formaPago;
            Compra.FormaEnvio = formaEnvio;
            Console.WriteLine($"La orden se encuentra en espera, los datos son:\n\tprecio:{precio}\n\tforma de pago:{formaPago}\n\tforma de envio: {formaEnvio}");
            Compra.EstadoActual = Compra.enEspera; 
        }

        public override void Cancelar()
        {
            Console.WriteLine("La orden ha sido cancelada");
            Compra.EstadoActual = Compra.cancelada;
        }

       
    }
}
